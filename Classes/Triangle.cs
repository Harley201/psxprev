﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using OpenTK;

namespace PSXPrev.Classes
{
    public class Triangle
    {
        public enum PrimitiveTypeEnum
        {
            GsUF3,
            GsUF4,
            TMD_P_F3,
            TMD_P_G3,
            TMD_P_F3G,
            TMD_P_G3G,
            TMD_P_TF3,
            TMD_P_TG3,
            TMD_P_NF3,
            TMD_P_NG3,
            TMD_P_TNF3,
            TMD_P_TNG3,
            TMD_P_F4,
            TMD_P_G4,
            TMD_P_G4G,
            TMD_P_F4G,
            TMD_P_TF4,
            TMD_P_TG4,
            TMD_P_NF4,
            TMD_P_NG4,
            TMD_P_TNF4,
            TMD_P_TNG4,
            _poly_ft3,
            _poly_ft4,
            _poly_gt3,
            _poly_gt4,
            _poly_f3,
            _poly_f4,
            _poly_g3,
            _poly_g4,
            _poly_ft3c,
            _poly_ft4c,
            _poly_gt3c,
            _poly_gt4c,
            _poly_f3c,
            _poly_f4c,
            _poly_g3c,
            _poly_g4c
        }

        [Browsable(false)]
        public Vector3[] Vertices { get; set; }

        [Browsable(false)]
        public Vector3[] Normals { get; set; }

        [Browsable(false)]
        public Vector3[] Uv { get; set; }

        [Browsable(false)]
        public Color[] Colors { get; set; }

        [Browsable(false)]
        public uint[] OriginalVertexIndices { get; set; }
        
        [Browsable(false)]
        public uint[] OriginalNormalIndices { get; set; }

        [Browsable(false)]
        public uint[] AttachableIndices { get; set; }

        [Browsable(false)]
        public uint[] AttachedIndices { get; set; }

        public List<Tuple<uint, uint>> ExtraPaddingData { get; set; } = new List<Tuple<uint, uint>>();

        public Triangle()
        {

        }

        public Triangle(Triangle fromTriangle)
        {
            Vertices = fromTriangle.Vertices;
            Normals = fromTriangle.Normals;
            Uv = fromTriangle.Uv;
            Colors = fromTriangle.Colors;
            OriginalVertexIndices = fromTriangle.OriginalVertexIndices;
            OriginalNormalIndices = fromTriangle.OriginalNormalIndices;
            AttachableIndices = fromTriangle.AttachableIndices;
            AttachedIndices = fromTriangle.AttachedIndices;
        }
    }
}