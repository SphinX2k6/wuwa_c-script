using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200160F RID: 5647
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_KuroCacheBonesBase")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FAnimNode_KuroCacheBonesBase : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601460E RID: 83470 RVA: 0x001DF404 File Offset: 0x001DD604
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_KuroCacheBonesBase._ScriptStructPtr != 0) ? FAnimNode_KuroCacheBonesBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_KuroCacheBonesBase", ref FAnimNode_KuroCacheBonesBase._ScriptStructPtr);
		}

		// Token: 0x1700500D RID: 20493
		// (get) Token: 0x0601460F RID: 83471 RVA: 0x001DF428 File Offset: 0x001DD628
		// (set) Token: 0x06014610 RID: 83472 RVA: 0x001DF46B File Offset: 0x001DD66B
		public FPoseLink Source
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._Source) == null)
				{
					result = (this._Source = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_KuroCacheBonesBase.__PropertyOffset_Source, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_KuroCacheBonesBase.__PropertyOffset_Source, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700500E RID: 20494
		// (get) Token: 0x06014611 RID: 83473 RVA: 0x001DF48C File Offset: 0x001DD68C
		// (set) Token: 0x06014612 RID: 83474 RVA: 0x001DF4CF File Offset: 0x001DD6CF
		public TArray<FName> BoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BoneNames) == null)
				{
					result = (this._BoneNames = new TArray<FName>(base.NativePtr + (IntPtr)FAnimNode_KuroCacheBonesBase.__PropertyOffset_BoneNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneNames.CopyAssign(value);
			}
		}

		// Token: 0x1700500F RID: 20495
		// (get) Token: 0x06014613 RID: 83475 RVA: 0x001DF4DD File Offset: 0x001DD6DD
		// (set) Token: 0x06014614 RID: 83476 RVA: 0x001DF4ED File Offset: 0x001DD6ED
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroCacheBonesBase.__PropertyOffset_bEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroCacheBonesBase.__PropertyOffset_bEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x06014615 RID: 83477 RVA: 0x001DF4FE File Offset: 0x001DD6FE
		public FAnimNode_KuroCacheBonesBase()
		{
		}

		// Token: 0x06014616 RID: 83478 RVA: 0x001DF506 File Offset: 0x001DD706
		public FAnimNode_KuroCacheBonesBase(FPoseLink Source, TArray<FName> BoneNames, bool bEnable)
		{
			this.Source = Source;
			this.BoneNames = BoneNames;
			this.bEnable = bEnable;
		}

		// Token: 0x06014617 RID: 83479 RVA: 0x001DF523 File Offset: 0x001DD723
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_KuroCacheBonesBase.StaticStruct();
		}

		// Token: 0x06014618 RID: 83480 RVA: 0x001DF52F File Offset: 0x001DD72F
		[NullableContext(2)]
		public FAnimNode_KuroCacheBonesBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014619 RID: 83481 RVA: 0x001DF539 File Offset: 0x001DD739
		public FAnimNode_KuroCacheBonesBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601461A RID: 83482 RVA: 0x001DF544 File Offset: 0x001DD744
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_KuroCacheBonesBase(Pointer, false, true);
		}

		// Token: 0x0601461B RID: 83483 RVA: 0x001DF54E File Offset: 0x001DD74E
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_KuroCacheBonesBase(Pointer, MemoryOwner);
		}

		// Token: 0x0400B16C RID: 45420
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_KuroCacheBonesBase";

		// Token: 0x0400B16D RID: 45421
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B16E RID: 45422
		internal static int __PropertyOffset_Source;

		// Token: 0x0400B16F RID: 45423
		[Nullable(2)]
		private FPoseLink _Source;

		// Token: 0x0400B170 RID: 45424
		internal static int __PropertyOffset_BoneNames;

		// Token: 0x0400B171 RID: 45425
		[Nullable(2)]
		private TArray<FName> _BoneNames;

		// Token: 0x0400B172 RID: 45426
		internal static int __PropertyOffset_bEnable;
	}
}
