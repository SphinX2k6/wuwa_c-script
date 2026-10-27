using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000522 RID: 1314
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigHierarchyContainer")]
	[UnrealStructLayout(1248, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1248)]
	public class FRigHierarchyContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060044DE RID: 17630 RVA: 0x000667E2 File Offset: 0x000649E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigHierarchyContainer._ScriptStructPtr != 0) ? FRigHierarchyContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigHierarchyContainer", ref FRigHierarchyContainer._ScriptStructPtr);
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x060044DF RID: 17631 RVA: 0x00066808 File Offset: 0x00064A08
		// (set) Token: 0x060044E0 RID: 17632 RVA: 0x0006684B File Offset: 0x00064A4B
		public FRigBoneHierarchy BoneHierarchy
		{
			get
			{
				base.FastCheckIsValid();
				FRigBoneHierarchy result;
				if ((result = this._BoneHierarchy) == null)
				{
					result = (this._BoneHierarchy = new FRigBoneHierarchy(base.NativePtr + (IntPtr)FRigHierarchyContainer.__PropertyOffset_BoneHierarchy, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigBoneHierarchy.StaticStruct(), base.NativePtr + (IntPtr)FRigHierarchyContainer.__PropertyOffset_BoneHierarchy, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x060044E1 RID: 17633 RVA: 0x0006686C File Offset: 0x00064A6C
		// (set) Token: 0x060044E2 RID: 17634 RVA: 0x000668AF File Offset: 0x00064AAF
		public FRigSpaceHierarchy SpaceHierarchy
		{
			get
			{
				base.FastCheckIsValid();
				FRigSpaceHierarchy result;
				if ((result = this._SpaceHierarchy) == null)
				{
					result = (this._SpaceHierarchy = new FRigSpaceHierarchy(base.NativePtr + (IntPtr)FRigHierarchyContainer.__PropertyOffset_SpaceHierarchy, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigSpaceHierarchy.StaticStruct(), base.NativePtr + (IntPtr)FRigHierarchyContainer.__PropertyOffset_SpaceHierarchy, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x060044E3 RID: 17635 RVA: 0x000668D0 File Offset: 0x00064AD0
		// (set) Token: 0x060044E4 RID: 17636 RVA: 0x00066913 File Offset: 0x00064B13
		public FRigControlHierarchy ControlHierarchy
		{
			get
			{
				base.FastCheckIsValid();
				FRigControlHierarchy result;
				if ((result = this._ControlHierarchy) == null)
				{
					result = (this._ControlHierarchy = new FRigControlHierarchy(base.NativePtr + (IntPtr)FRigHierarchyContainer.__PropertyOffset_ControlHierarchy, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigControlHierarchy.StaticStruct(), base.NativePtr + (IntPtr)FRigHierarchyContainer.__PropertyOffset_ControlHierarchy, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x060044E5 RID: 17637 RVA: 0x00066934 File Offset: 0x00064B34
		// (set) Token: 0x060044E6 RID: 17638 RVA: 0x00066977 File Offset: 0x00064B77
		public FRigCurveContainer CurveContainer
		{
			get
			{
				base.FastCheckIsValid();
				FRigCurveContainer result;
				if ((result = this._CurveContainer) == null)
				{
					result = (this._CurveContainer = new FRigCurveContainer(base.NativePtr + (IntPtr)FRigHierarchyContainer.__PropertyOffset_CurveContainer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigCurveContainer.StaticStruct(), base.NativePtr + (IntPtr)FRigHierarchyContainer.__PropertyOffset_CurveContainer, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x060044E7 RID: 17639 RVA: 0x00066998 File Offset: 0x00064B98
		// (set) Token: 0x060044E8 RID: 17640 RVA: 0x000669A8 File Offset: 0x00064BA8
		public unsafe int Version
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigHierarchyContainer.__PropertyOffset_Version);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigHierarchyContainer.__PropertyOffset_Version) = value;
			}
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x000669B9 File Offset: 0x00064BB9
		public FRigHierarchyContainer()
		{
		}

		// Token: 0x060044EA RID: 17642 RVA: 0x000669C1 File Offset: 0x00064BC1
		public FRigHierarchyContainer(FRigBoneHierarchy BoneHierarchy, FRigSpaceHierarchy SpaceHierarchy, FRigControlHierarchy ControlHierarchy, FRigCurveContainer CurveContainer, int Version)
		{
			this.BoneHierarchy = BoneHierarchy;
			this.SpaceHierarchy = SpaceHierarchy;
			this.ControlHierarchy = ControlHierarchy;
			this.CurveContainer = CurveContainer;
			this.Version = Version;
		}

		// Token: 0x060044EB RID: 17643 RVA: 0x000669EE File Offset: 0x00064BEE
		protected override IntPtr GetUStructPtr()
		{
			return FRigHierarchyContainer.StaticStruct();
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x000669FA File Offset: 0x00064BFA
		[NullableContext(2)]
		public FRigHierarchyContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x00066A04 File Offset: 0x00064C04
		public FRigHierarchyContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x00066A0F File Offset: 0x00064C0F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigHierarchyContainer(Pointer, false, true);
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x00066A19 File Offset: 0x00064C19
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigHierarchyContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04002189 RID: 8585
		public const string __ObjectPath = "/Script/ControlRig.RigHierarchyContainer";

		// Token: 0x0400218A RID: 8586
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400218B RID: 8587
		internal static int __PropertyOffset_BoneHierarchy;

		// Token: 0x0400218C RID: 8588
		[Nullable(2)]
		private FRigBoneHierarchy _BoneHierarchy;

		// Token: 0x0400218D RID: 8589
		internal static int __PropertyOffset_SpaceHierarchy;

		// Token: 0x0400218E RID: 8590
		[Nullable(2)]
		private FRigSpaceHierarchy _SpaceHierarchy;

		// Token: 0x0400218F RID: 8591
		internal static int __PropertyOffset_ControlHierarchy;

		// Token: 0x04002190 RID: 8592
		[Nullable(2)]
		private FRigControlHierarchy _ControlHierarchy;

		// Token: 0x04002191 RID: 8593
		internal static int __PropertyOffset_CurveContainer;

		// Token: 0x04002192 RID: 8594
		[Nullable(2)]
		private FRigCurveContainer _CurveContainer;

		// Token: 0x04002193 RID: 8595
		internal static int __PropertyOffset_Version;
	}
}
