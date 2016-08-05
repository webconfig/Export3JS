﻿using UnityEngine;
using System.Collections.Generic;

namespace Export3JS.Model {

    public struct MaterialType {
        public static string MeshBasicMaterial = "MeshBasicMaterial";
        public static string MeshPhongMaterial = "MeshPhongMaterial";
        public static string MultiMaterial = "MultiMaterial";
    }

    public class Material3JS {

        public string uuid;
        public string name;
        public string type;
        
        public float opacity; // Material.color.a
        public bool transparent; // ?
        public bool wireframe; // ? false

        public Material3JS() {
            uuid = System.Guid.NewGuid().ToString().ToUpper();
            type = MaterialType.MeshPhongMaterial;
        }
    }

    public class MeshBasicMaterial3JS : Material3JS {

        public string map;
        public int color; // Material.color

        public MeshBasicMaterial3JS() : base() {
            type = MaterialType.MeshBasicMaterial;
        }
    }

    public class MeshPhongMaterial3JS : Material3JS {

        public string map;
        public int color; // Material.color
        public int ambient; // _AmbientColor
        public int emissive; // _EmissionColor
        public int specular; // _SpecColor
        public float shininess; // _Shininess

        public MeshPhongMaterial3JS() : base() {
            type = MaterialType.MeshPhongMaterial;
        }

    }

    public class MultiMaterial3JS : Material3JS {

        public List<Material3JS> materials;

        public MultiMaterial3JS() : base() {
            type = MaterialType.MultiMaterial;
            materials = new List<Material3JS>();
        }
    }
}