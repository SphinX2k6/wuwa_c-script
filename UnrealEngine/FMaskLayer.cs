using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001677 RID: 5751
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.MaskLayer")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMaskLayer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014DD3 RID: 85459 RVA: 0x001EAD05 File Offset: 0x001E8F05
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaskLayer._ScriptStructPtr != 0) ? FMaskLayer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.MaskLayer", ref FMaskLayer._ScriptStructPtr);
		}

		// Token: 0x170052A4 RID: 21156
		// (get) Token: 0x06014DD4 RID: 85460 RVA: 0x001EAD2C File Offset: 0x001E8F2C
		// (set) Token: 0x06014DD5 RID: 85461 RVA: 0x001EAD6F File Offset: 0x001E8F6F
		public TArray<FBranchBlendFilter> MaskLayer
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBranchBlendFilter> result;
				if ((result = this._MaskLayer) == null)
				{
					result = (this._MaskLayer = new TArray<FBranchBlendFilter>(base.NativePtr + (IntPtr)FMaskLayer.__PropertyOffset_MaskLayer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaskLayer.CopyAssign(value);
			}
		}

		// Token: 0x06014DD6 RID: 85462 RVA: 0x001EAD7D File Offset: 0x001E8F7D
		public FMaskLayer()
		{
		}

		// Token: 0x06014DD7 RID: 85463 RVA: 0x001EAD85 File Offset: 0x001E8F85
		public FMaskLayer(TArray<FBranchBlendFilter> MaskLayer)
		{
			this.MaskLayer = MaskLayer;
		}

		// Token: 0x06014DD8 RID: 85464 RVA: 0x001EAD94 File Offset: 0x001E8F94
		protected override IntPtr GetUStructPtr()
		{
			return FMaskLayer.StaticStruct();
		}

		// Token: 0x06014DD9 RID: 85465 RVA: 0x001EADA0 File Offset: 0x001E8FA0
		[NullableContext(2)]
		public FMaskLayer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014DDA RID: 85466 RVA: 0x001EADAA File Offset: 0x001E8FAA
		public FMaskLayer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014DDB RID: 85467 RVA: 0x001EADB5 File Offset: 0x001E8FB5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaskLayer(Pointer, false, true);
		}

		// Token: 0x06014DDC RID: 85468 RVA: 0x001EADBF File Offset: 0x001E8FBF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaskLayer(Pointer, MemoryOwner);
		}

		// Token: 0x0400B5EB RID: 46571
		public const string __ObjectPath = "/Script/KuroAnim.MaskLayer";

		// Token: 0x0400B5EC RID: 46572
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B5ED RID: 46573
		internal static int __PropertyOffset_MaskLayer;

		// Token: 0x0400B5EE RID: 46574
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBranchBlendFilter> _MaskLayer;
	}
}
