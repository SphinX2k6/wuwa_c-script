using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A95 RID: 2709
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EKuroStreamingGroup")]
	public enum EKuroStreamingGroup : byte
	{
		// Token: 0x0400488E RID: 18574
		KuroStreamingGroup_UnclassifiedTexture,
		// Token: 0x0400488F RID: 18575
		KuroStreamingGroup_LandmarkTexture,
		// Token: 0x04004890 RID: 18576
		KuroStreamingGroup_RoleTexture,
		// Token: 0x04004891 RID: 18577
		KuroStreamingGroup_WeaponTexture,
		// Token: 0x04004892 RID: 18578
		KuroStreamingGroup_HugeMonsterTexture,
		// Token: 0x04004893 RID: 18579
		KuroStreamingGroup_LargeMonsterTexture,
		// Token: 0x04004894 RID: 18580
		KuroStreamingGroup_MediumMonsterTexture,
		// Token: 0x04004895 RID: 18581
		KuroStreamingGroup_HugeNpcTexture,
		// Token: 0x04004896 RID: 18582
		KuroStreamingGroup_LargeNpcTexture,
		// Token: 0x04004897 RID: 18583
		KuroStreamingGroup_MediumNpcTexture,
		// Token: 0x04004898 RID: 18584
		KuroStreamingGroup_HugeRocTexture,
		// Token: 0x04004899 RID: 18585
		KuroStreamingGroup_LargeRocTexture,
		// Token: 0x0400489A RID: 18586
		KuroStreamingGroup_MediumRocTexture,
		// Token: 0x0400489B RID: 18587
		KuroStreamingGroup_HugeFoliageTexture,
		// Token: 0x0400489C RID: 18588
		KuroStreamingGroup_LargeFoliageTexture,
		// Token: 0x0400489D RID: 18589
		KuroStreamingGroup_MediumFoliageTexture,
		// Token: 0x0400489E RID: 18590
		KuroStreamingGroup_HugeBuildingTexture,
		// Token: 0x0400489F RID: 18591
		KuroStreamingGroup_LargeBuildingTexture,
		// Token: 0x040048A0 RID: 18592
		KuroStreamingGroup_MediumBuildingTexture,
		// Token: 0x040048A1 RID: 18593
		KuroStreamingGroup_HugePropTexture,
		// Token: 0x040048A2 RID: 18594
		KuroStreamingGroup_LargePropTexture,
		// Token: 0x040048A3 RID: 18595
		KuroStreamingGroup_MediumPropTexture,
		// Token: 0x040048A4 RID: 18596
		KuroStreamingGroup_HugeFXTexture,
		// Token: 0x040048A5 RID: 18597
		KuroStreamingGroup_LargeFXTexture,
		// Token: 0x040048A6 RID: 18598
		KuroStreamingGroup_MediumFXTexture,
		// Token: 0x040048A7 RID: 18599
		KuroStreamingGroup_CommonHLODTexture,
		// Token: 0x040048A8 RID: 18600
		KuroStreamingGroup_LandscapeHLODTexture,
		// Token: 0x040048A9 RID: 18601
		KuroStreamingGroup_LandscapeRenderBias0Texture,
		// Token: 0x040048AA RID: 18602
		KuroStreamingGroup_LandscapeRenderBias1Texture,
		// Token: 0x040048AB RID: 18603
		KuroStreamingGroup_LandscapeRenderBias2Texture,
		// Token: 0x040048AC RID: 18604
		KuroStreamingGroup_UnclassifiedMesh,
		// Token: 0x040048AD RID: 18605
		KuroStreamingGroup_LandmarkMesh,
		// Token: 0x040048AE RID: 18606
		KuroStreamingGroup_RoleMesh,
		// Token: 0x040048AF RID: 18607
		KuroStreamingGroup_WeaponMesh,
		// Token: 0x040048B0 RID: 18608
		KuroStreamingGroup_HugeMonsterMesh,
		// Token: 0x040048B1 RID: 18609
		KuroStreamingGroup_LargeMonsterMesh,
		// Token: 0x040048B2 RID: 18610
		KuroStreamingGroup_MediumMonsterMesh,
		// Token: 0x040048B3 RID: 18611
		KuroStreamingGroup_HugeNpcMesh,
		// Token: 0x040048B4 RID: 18612
		KuroStreamingGroup_LargeNpcMesh,
		// Token: 0x040048B5 RID: 18613
		KuroStreamingGroup_MediumNpcMesh,
		// Token: 0x040048B6 RID: 18614
		KuroStreamingGroup_HugeRocMesh,
		// Token: 0x040048B7 RID: 18615
		KuroStreamingGroup_LargeRocMesh,
		// Token: 0x040048B8 RID: 18616
		KuroStreamingGroup_MediumRocMesh,
		// Token: 0x040048B9 RID: 18617
		KuroStreamingGroup_HugeFoliageMesh,
		// Token: 0x040048BA RID: 18618
		KuroStreamingGroup_LargeFoliageMesh,
		// Token: 0x040048BB RID: 18619
		KuroStreamingGroup_MediumFoliageMesh,
		// Token: 0x040048BC RID: 18620
		KuroStreamingGroup_HugeBuildingMesh,
		// Token: 0x040048BD RID: 18621
		KuroStreamingGroup_LargeBuildingMesh,
		// Token: 0x040048BE RID: 18622
		KuroStreamingGroup_MediumBuildingMesh,
		// Token: 0x040048BF RID: 18623
		KuroStreamingGroup_HugePropMesh,
		// Token: 0x040048C0 RID: 18624
		KuroStreamingGroup_LargePropMesh,
		// Token: 0x040048C1 RID: 18625
		KuroStreamingGroup_MediumPropMesh,
		// Token: 0x040048C2 RID: 18626
		KuroStreamingGroup_CommonHLODMesh,
		// Token: 0x040048C3 RID: 18627
		KuroStreamingGroup_LandscapeHLODMesh,
		// Token: 0x040048C4 RID: 18628
		KuroStreamingGroup_LandscapeTextureArray,
		// Token: 0x040048C5 RID: 18629
		KuroStreamingGroup_BuildingTextureArray,
		// Token: 0x040048C6 RID: 18630
		KuroStreamingGroup_CommonCubeMap,
		// Token: 0x040048C7 RID: 18631
		KuroStreamingGroup_PBRCubeMap,
		// Token: 0x040048C8 RID: 18632
		KuroStreamingGroup_UITexture,
		// Token: 0x040048C9 RID: 18633
		KuroStreamingGroup_T4MMesh,
		// Token: 0x040048CA RID: 18634
		KuroStreamingGroup_T4MTexture,
		// Token: 0x040048CB RID: 18635
		KuroStreamingGroup_Runtime1x1Texture,
		// Token: 0x040048CC RID: 18636
		KuroStreamingGroup_ConditionalRuntime1x1Texture,
		// Token: 0x040048CD RID: 18637
		KuroStreamingGroup_LandscapeHeightmapCookNoMipsTexture,
		// Token: 0x040048CE RID: 18638
		KuroStreamingGroup_LandscapeHeightmapCookMinMipsPlus0Texture,
		// Token: 0x040048CF RID: 18639
		KuroStreamingGroup_LandscapeHeightmapCookMinMipsPlus1Texture,
		// Token: 0x040048D0 RID: 18640
		KuroStreamingGroup_LandscapeHeightmapCookMinMipsPlus2Texture,
		// Token: 0x040048D1 RID: 18641
		KuroStreamingGroup_LandscapeWeightmapCookNoMipsTexture,
		// Token: 0x040048D2 RID: 18642
		KuroStreamingGroup_LandscapeWeightmapCookMinMipsPlus0Texture,
		// Token: 0x040048D3 RID: 18643
		KuroStreamingGroup_LandscapeWeightmapCookMinMipsPlus1Texture,
		// Token: 0x040048D4 RID: 18644
		KuroStreamingGroup_LandscapeWeightmapCookMinMipsPlus2Texture,
		// Token: 0x040048D5 RID: 18645
		KuroStreamingGroup_LandscapeIndexmapCookNoMipsTexture,
		// Token: 0x040048D6 RID: 18646
		KuroStreamingGroup_LandscapeIndexmapCookMinMipsPlus0Texture,
		// Token: 0x040048D7 RID: 18647
		KuroStreamingGroup_LandscapeIndexmapCookMinMipsPlus1Texture,
		// Token: 0x040048D8 RID: 18648
		KuroStreamingGroup_LandscapeIndexmapCookMinMipsPlus2Texture,
		// Token: 0x040048D9 RID: 18649
		KuroStreamingGroup_LandscapeBlendmapCookNoMipsTexture,
		// Token: 0x040048DA RID: 18650
		KuroStreamingGroup_LandscapeBlendmapCookMinMipsPlus0Texture,
		// Token: 0x040048DB RID: 18651
		KuroStreamingGroup_LandscapeBlendmapCookMinMipsPlus1Texture,
		// Token: 0x040048DC RID: 18652
		KuroStreamingGroup_LandscapeBlendmapCookMinMipsPlus2Texture,
		// Token: 0x040048DD RID: 18653
		KuroStreamingGroup_StreamableLandscapeArrayTexture,
		// Token: 0x040048DE RID: 18654
		KuroStreamingGroup_StreamableBuildingArrayTexture,
		// Token: 0x040048DF RID: 18655
		KuroStreamingGroup_StreamableCommonArrayTexture,
		// Token: 0x040048E0 RID: 18656
		KuroStreamingGroup_CommonArrayTexture,
		// Token: 0x040048E1 RID: 18657
		KuroStreamingGroup_MAX
	}
}
