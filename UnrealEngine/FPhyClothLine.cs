using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200167D RID: 5757
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.PhyClothLine")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FPhyClothLine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014E36 RID: 85558 RVA: 0x001EB5C4 File Offset: 0x001E97C4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPhyClothLine._ScriptStructPtr != 0) ? FPhyClothLine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.PhyClothLine", ref FPhyClothLine._ScriptStructPtr);
		}

		// Token: 0x170052BF RID: 21183
		// (get) Token: 0x06014E37 RID: 85559 RVA: 0x001EB5E8 File Offset: 0x001E97E8
		// (set) Token: 0x06014E38 RID: 85560 RVA: 0x001EB62B File Offset: 0x001E982B
		public FBoneReference RootBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._RootBone) == null)
				{
					result = (this._RootBone = new FBoneReference(base.NativePtr + (IntPtr)FPhyClothLine.__PropertyOffset_RootBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FPhyClothLine.__PropertyOffset_RootBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170052C0 RID: 21184
		// (get) Token: 0x06014E39 RID: 85561 RVA: 0x001EB64C File Offset: 0x001E984C
		// (set) Token: 0x06014E3A RID: 85562 RVA: 0x001EB65C File Offset: 0x001E985C
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhyClothLine.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothLine.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x170052C1 RID: 21185
		// (get) Token: 0x06014E3B RID: 85563 RVA: 0x001EB66D File Offset: 0x001E986D
		// (set) Token: 0x06014E3C RID: 85564 RVA: 0x001EB67D File Offset: 0x001E987D
		public unsafe int Generate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhyClothLine.__PropertyOffset_Generate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothLine.__PropertyOffset_Generate) = value;
			}
		}

		// Token: 0x06014E3D RID: 85565 RVA: 0x001EB68E File Offset: 0x001E988E
		public FPhyClothLine()
		{
		}

		// Token: 0x06014E3E RID: 85566 RVA: 0x001EB696 File Offset: 0x001E9896
		public FPhyClothLine(FBoneReference RootBone, float Thickness, int Generate)
		{
			this.RootBone = RootBone;
			this.Thickness = Thickness;
			this.Generate = Generate;
		}

		// Token: 0x06014E3F RID: 85567 RVA: 0x001EB6B3 File Offset: 0x001E98B3
		protected override IntPtr GetUStructPtr()
		{
			return FPhyClothLine.StaticStruct();
		}

		// Token: 0x06014E40 RID: 85568 RVA: 0x001EB6BF File Offset: 0x001E98BF
		[NullableContext(2)]
		public FPhyClothLine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014E41 RID: 85569 RVA: 0x001EB6C9 File Offset: 0x001E98C9
		public FPhyClothLine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014E42 RID: 85570 RVA: 0x001EB6D4 File Offset: 0x001E98D4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPhyClothLine(Pointer, false, true);
		}

		// Token: 0x06014E43 RID: 85571 RVA: 0x001EB6DE File Offset: 0x001E98DE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPhyClothLine(Pointer, MemoryOwner);
		}

		// Token: 0x0400B61B RID: 46619
		public const string __ObjectPath = "/Script/KuroAnim.PhyClothLine";

		// Token: 0x0400B61C RID: 46620
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B61D RID: 46621
		internal static int __PropertyOffset_RootBone;

		// Token: 0x0400B61E RID: 46622
		[Nullable(2)]
		private FBoneReference _RootBone;

		// Token: 0x0400B61F RID: 46623
		internal static int __PropertyOffset_Thickness;

		// Token: 0x0400B620 RID: 46624
		internal static int __PropertyOffset_Generate;
	}
}
