using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F6E RID: 8046
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeComponentMaterialOverride")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FLandscapeComponentMaterialOverride : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E88B RID: 125067 RVA: 0x002D62A2 File Offset: 0x002D44A2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandscapeComponentMaterialOverride._ScriptStructPtr != 0) ? FLandscapeComponentMaterialOverride._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.LandscapeComponentMaterialOverride", ref FLandscapeComponentMaterialOverride._ScriptStructPtr);
		}

		// Token: 0x1700797C RID: 31100
		// (get) Token: 0x0601E88C RID: 125068 RVA: 0x002D62C8 File Offset: 0x002D44C8
		// (set) Token: 0x0601E88D RID: 125069 RVA: 0x002D630B File Offset: 0x002D450B
		public FPerPlatformInt LODIndex
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._LODIndex) == null)
				{
					result = (this._LODIndex = new FPerPlatformInt(base.NativePtr + (IntPtr)FLandscapeComponentMaterialOverride.__PropertyOffset_LODIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)FLandscapeComponentMaterialOverride.__PropertyOffset_LODIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700797D RID: 31101
		// (get) Token: 0x0601E88E RID: 125070 RVA: 0x002D632C File Offset: 0x002D452C
		// (set) Token: 0x0601E88F RID: 125071 RVA: 0x002D6340 File Offset: 0x002D4540
		[Nullable(2)]
		public unsafe UMaterialInterface Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeComponentMaterialOverride.__PropertyOffset_Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeComponentMaterialOverride.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x0601E890 RID: 125072 RVA: 0x002D6355 File Offset: 0x002D4555
		public FLandscapeComponentMaterialOverride()
		{
		}

		// Token: 0x0601E891 RID: 125073 RVA: 0x002D635D File Offset: 0x002D455D
		public FLandscapeComponentMaterialOverride(FPerPlatformInt LODIndex, UMaterialInterface Material)
		{
			this.LODIndex = LODIndex;
			this.Material = Material;
		}

		// Token: 0x0601E892 RID: 125074 RVA: 0x002D6373 File Offset: 0x002D4573
		protected override IntPtr GetUStructPtr()
		{
			return FLandscapeComponentMaterialOverride.StaticStruct();
		}

		// Token: 0x0601E893 RID: 125075 RVA: 0x002D637F File Offset: 0x002D457F
		[NullableContext(2)]
		public FLandscapeComponentMaterialOverride(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E894 RID: 125076 RVA: 0x002D6389 File Offset: 0x002D4589
		public FLandscapeComponentMaterialOverride(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E895 RID: 125077 RVA: 0x002D6394 File Offset: 0x002D4594
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandscapeComponentMaterialOverride(Pointer, false, true);
		}

		// Token: 0x0601E896 RID: 125078 RVA: 0x002D639E File Offset: 0x002D459E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandscapeComponentMaterialOverride(Pointer, MemoryOwner);
		}

		// Token: 0x0401080A RID: 67594
		public const string __ObjectPath = "/Script/Landscape.LandscapeComponentMaterialOverride";

		// Token: 0x0401080B RID: 67595
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401080C RID: 67596
		internal static int __PropertyOffset_LODIndex;

		// Token: 0x0401080D RID: 67597
		[Nullable(2)]
		private FPerPlatformInt _LODIndex;

		// Token: 0x0401080E RID: 67598
		internal static int __PropertyOffset_Material;
	}
}
