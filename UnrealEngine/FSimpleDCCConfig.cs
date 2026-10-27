using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001681 RID: 5761
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.SimpleDCCConfig")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FSimpleDCCConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014E6E RID: 85614 RVA: 0x001EBA35 File Offset: 0x001E9C35
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSimpleDCCConfig._ScriptStructPtr != 0) ? FSimpleDCCConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.SimpleDCCConfig", ref FSimpleDCCConfig._ScriptStructPtr);
		}

		// Token: 0x170052CF RID: 21199
		// (get) Token: 0x06014E6F RID: 85615 RVA: 0x001EBA5C File Offset: 0x001E9C5C
		// (set) Token: 0x06014E70 RID: 85616 RVA: 0x001EBA9F File Offset: 0x001E9C9F
		public FBoneReference ParentBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._ParentBone) == null)
				{
					result = (this._ParentBone = new FBoneReference(base.NativePtr + (IntPtr)FSimpleDCCConfig.__PropertyOffset_ParentBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FSimpleDCCConfig.__PropertyOffset_ParentBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170052D0 RID: 21200
		// (get) Token: 0x06014E71 RID: 85617 RVA: 0x001EBAC0 File Offset: 0x001E9CC0
		// (set) Token: 0x06014E72 RID: 85618 RVA: 0x001EBB03 File Offset: 0x001E9D03
		public TArray<FBoneReference> ChildBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneReference> result;
				if ((result = this._ChildBones) == null)
				{
					result = (this._ChildBones = new TArray<FBoneReference>(base.NativePtr + (IntPtr)FSimpleDCCConfig.__PropertyOffset_ChildBones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ChildBones.CopyAssign(value);
			}
		}

		// Token: 0x170052D1 RID: 21201
		// (get) Token: 0x06014E73 RID: 85619 RVA: 0x001EBB11 File Offset: 0x001E9D11
		// (set) Token: 0x06014E74 RID: 85620 RVA: 0x001EBB25 File Offset: 0x001E9D25
		public unsafe FVector BaseOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimpleDCCConfig.__PropertyOffset_BaseOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimpleDCCConfig.__PropertyOffset_BaseOffset) = value;
			}
		}

		// Token: 0x170052D2 RID: 21202
		// (get) Token: 0x06014E75 RID: 85621 RVA: 0x001EBB3A File Offset: 0x001E9D3A
		// (set) Token: 0x06014E76 RID: 85622 RVA: 0x001EBB4A File Offset: 0x001E9D4A
		public unsafe float LocationFixAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimpleDCCConfig.__PropertyOffset_LocationFixAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimpleDCCConfig.__PropertyOffset_LocationFixAlpha) = value;
			}
		}

		// Token: 0x170052D3 RID: 21203
		// (get) Token: 0x06014E77 RID: 85623 RVA: 0x001EBB5B File Offset: 0x001E9D5B
		// (set) Token: 0x06014E78 RID: 85624 RVA: 0x001EBB6B File Offset: 0x001E9D6B
		public unsafe float RotateFixAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimpleDCCConfig.__PropertyOffset_RotateFixAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimpleDCCConfig.__PropertyOffset_RotateFixAlpha) = value;
			}
		}

		// Token: 0x06014E79 RID: 85625 RVA: 0x001EBB7C File Offset: 0x001E9D7C
		public FSimpleDCCConfig()
		{
		}

		// Token: 0x06014E7A RID: 85626 RVA: 0x001EBB84 File Offset: 0x001E9D84
		public FSimpleDCCConfig(FBoneReference ParentBone, TArray<FBoneReference> ChildBones, FVector BaseOffset, float LocationFixAlpha, float RotateFixAlpha)
		{
			this.ParentBone = ParentBone;
			this.ChildBones = ChildBones;
			this.BaseOffset = BaseOffset;
			this.LocationFixAlpha = LocationFixAlpha;
			this.RotateFixAlpha = RotateFixAlpha;
		}

		// Token: 0x06014E7B RID: 85627 RVA: 0x001EBBB1 File Offset: 0x001E9DB1
		protected override IntPtr GetUStructPtr()
		{
			return FSimpleDCCConfig.StaticStruct();
		}

		// Token: 0x06014E7C RID: 85628 RVA: 0x001EBBBD File Offset: 0x001E9DBD
		[NullableContext(2)]
		public FSimpleDCCConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014E7D RID: 85629 RVA: 0x001EBBC7 File Offset: 0x001E9DC7
		public FSimpleDCCConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014E7E RID: 85630 RVA: 0x001EBBD2 File Offset: 0x001E9DD2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSimpleDCCConfig(Pointer, false, true);
		}

		// Token: 0x06014E7F RID: 85631 RVA: 0x001EBBDC File Offset: 0x001E9DDC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSimpleDCCConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400B639 RID: 46649
		public const string __ObjectPath = "/Script/KuroAnim.SimpleDCCConfig";

		// Token: 0x0400B63A RID: 46650
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B63B RID: 46651
		internal static int __PropertyOffset_ParentBone;

		// Token: 0x0400B63C RID: 46652
		[Nullable(2)]
		private FBoneReference _ParentBone;

		// Token: 0x0400B63D RID: 46653
		internal static int __PropertyOffset_ChildBones;

		// Token: 0x0400B63E RID: 46654
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneReference> _ChildBones;

		// Token: 0x0400B63F RID: 46655
		internal static int __PropertyOffset_BaseOffset;

		// Token: 0x0400B640 RID: 46656
		internal static int __PropertyOffset_LocationFixAlpha;

		// Token: 0x0400B641 RID: 46657
		internal static int __PropertyOffset_RotateFixAlpha;
	}
}
