using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000881 RID: 2177
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneMeshInstanceGroupLODData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FBakedBoneMeshInstanceGroupLODData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007721 RID: 30497 RVA: 0x000AA95D File Offset: 0x000A8B5D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedBoneMeshInstanceGroupLODData._ScriptStructPtr != 0) ? FBakedBoneMeshInstanceGroupLODData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedBoneMeshInstanceGroupLODData", ref FBakedBoneMeshInstanceGroupLODData._ScriptStructPtr);
		}

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x06007722 RID: 30498 RVA: 0x000AA981 File Offset: 0x000A8B81
		// (set) Token: 0x06007723 RID: 30499 RVA: 0x000AA995 File Offset: 0x000A8B95
		[Nullable(2)]
		public unsafe USkeletalMesh SourceMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneMeshInstanceGroupLODData.__PropertyOffset_SourceMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBakedBoneMeshInstanceGroupLODData.__PropertyOffset_SourceMesh, value);
			}
		}

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x06007724 RID: 30500 RVA: 0x000AA9AC File Offset: 0x000A8BAC
		// (set) Token: 0x06007725 RID: 30501 RVA: 0x000AA9EF File Offset: 0x000A8BEF
		public TArray<UBakedBoneTexture2D> BakedBoneTextureLODData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBakedBoneTexture2D> result;
				if ((result = this._BakedBoneTextureLODData) == null)
				{
					result = (this._BakedBoneTextureLODData = new TArray<UBakedBoneTexture2D>(base.NativePtr + (IntPtr)FBakedBoneMeshInstanceGroupLODData.__PropertyOffset_BakedBoneTextureLODData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BakedBoneTextureLODData.CopyAssign(value);
			}
		}

		// Token: 0x06007726 RID: 30502 RVA: 0x000AA9FD File Offset: 0x000A8BFD
		public FBakedBoneMeshInstanceGroupLODData()
		{
		}

		// Token: 0x06007727 RID: 30503 RVA: 0x000AAA05 File Offset: 0x000A8C05
		public FBakedBoneMeshInstanceGroupLODData(USkeletalMesh SourceMesh, TArray<UBakedBoneTexture2D> BakedBoneTextureLODData)
		{
			this.SourceMesh = SourceMesh;
			this.BakedBoneTextureLODData = BakedBoneTextureLODData;
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x000AAA1B File Offset: 0x000A8C1B
		protected override IntPtr GetUStructPtr()
		{
			return FBakedBoneMeshInstanceGroupLODData.StaticStruct();
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x000AAA27 File Offset: 0x000A8C27
		[NullableContext(2)]
		public FBakedBoneMeshInstanceGroupLODData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x000AAA31 File Offset: 0x000A8C31
		public FBakedBoneMeshInstanceGroupLODData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x000AAA3C File Offset: 0x000A8C3C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedBoneMeshInstanceGroupLODData(Pointer, false, true);
		}

		// Token: 0x0600772C RID: 30508 RVA: 0x000AAA46 File Offset: 0x000A8C46
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedBoneMeshInstanceGroupLODData(Pointer, MemoryOwner);
		}

		// Token: 0x04003931 RID: 14641
		public const string __ObjectPath = "/Script/Engine.BakedBoneMeshInstanceGroupLODData";

		// Token: 0x04003932 RID: 14642
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003933 RID: 14643
		internal static int __PropertyOffset_SourceMesh;

		// Token: 0x04003934 RID: 14644
		internal static int __PropertyOffset_BakedBoneTextureLODData;

		// Token: 0x04003935 RID: 14645
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBakedBoneTexture2D> _BakedBoneTextureLODData;
	}
}
