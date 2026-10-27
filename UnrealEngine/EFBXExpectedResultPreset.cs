using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A18 RID: 10776
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EFBXExpectedResultPreset")]
	public enum EFBXExpectedResultPreset
	{
		// Token: 0x04015DBE RID: 89534
		Error_Number,
		// Token: 0x04015DBF RID: 89535
		Warning_Number,
		// Token: 0x04015DC0 RID: 89536
		Created_Staticmesh_Number,
		// Token: 0x04015DC1 RID: 89537
		Created_Skeletalmesh_Number,
		// Token: 0x04015DC2 RID: 89538
		Materials_Created_Number,
		// Token: 0x04015DC3 RID: 89539
		Material_Slot_Imported_Name,
		// Token: 0x04015DC4 RID: 89540
		Vertex_Number,
		// Token: 0x04015DC5 RID: 89541
		Lod_Number,
		// Token: 0x04015DC6 RID: 89542
		Vertex_Number_Lod,
		// Token: 0x04015DC7 RID: 89543
		Mesh_Materials_Number,
		// Token: 0x04015DC8 RID: 89544
		Mesh_LOD_Section_Number,
		// Token: 0x04015DC9 RID: 89545
		Mesh_LOD_Section_Vertex_Number,
		// Token: 0x04015DCA RID: 89546
		Mesh_LOD_Section_Triangle_Number,
		// Token: 0x04015DCB RID: 89547
		Mesh_LOD_Section_Material_Name,
		// Token: 0x04015DCC RID: 89548
		Mesh_LOD_Section_Material_Index,
		// Token: 0x04015DCD RID: 89549
		Mesh_LOD_Section_Material_Imported_Name,
		// Token: 0x04015DCE RID: 89550
		Mesh_LOD_Vertex_Position,
		// Token: 0x04015DCF RID: 89551
		Mesh_LOD_Vertex_Normal,
		// Token: 0x04015DD0 RID: 89552
		LOD_UV_Channel_Number,
		// Token: 0x04015DD1 RID: 89553
		Bone_Number,
		// Token: 0x04015DD2 RID: 89554
		Bone_Position,
		// Token: 0x04015DD3 RID: 89555
		Animation_Frame_Number,
		// Token: 0x04015DD4 RID: 89556
		Animation_Length,
		// Token: 0x04015DD5 RID: 89557
		EFBXExpectedResultPreset_MAX
	}
}
