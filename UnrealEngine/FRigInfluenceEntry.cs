using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000525 RID: 1317
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigInfluenceEntry")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigInfluenceEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004505 RID: 17669 RVA: 0x00066C89 File Offset: 0x00064E89
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigInfluenceEntry._ScriptStructPtr != 0) ? FRigInfluenceEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigInfluenceEntry", ref FRigInfluenceEntry._ScriptStructPtr);
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x06004506 RID: 17670 RVA: 0x00066CB0 File Offset: 0x00064EB0
		// (set) Token: 0x06004507 RID: 17671 RVA: 0x00066CF3 File Offset: 0x00064EF3
		public FRigElementKey Source
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Source) == null)
				{
					result = (this._Source = new FRigElementKey(base.NativePtr + (IntPtr)FRigInfluenceEntry.__PropertyOffset_Source, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigInfluenceEntry.__PropertyOffset_Source, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06004508 RID: 17672 RVA: 0x00066D14 File Offset: 0x00064F14
		// (set) Token: 0x06004509 RID: 17673 RVA: 0x00066D57 File Offset: 0x00064F57
		public TArray<FRigElementKey> AffectedList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigElementKey> result;
				if ((result = this._AffectedList) == null)
				{
					result = (this._AffectedList = new TArray<FRigElementKey>(base.NativePtr + (IntPtr)FRigInfluenceEntry.__PropertyOffset_AffectedList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AffectedList.CopyAssign(value);
			}
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x00066D65 File Offset: 0x00064F65
		public FRigInfluenceEntry()
		{
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x00066D6D File Offset: 0x00064F6D
		public FRigInfluenceEntry(FRigElementKey Source, TArray<FRigElementKey> AffectedList)
		{
			this.Source = Source;
			this.AffectedList = AffectedList;
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x00066D83 File Offset: 0x00064F83
		protected override IntPtr GetUStructPtr()
		{
			return FRigInfluenceEntry.StaticStruct();
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x00066D8F File Offset: 0x00064F8F
		[NullableContext(2)]
		public FRigInfluenceEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x00066D99 File Offset: 0x00064F99
		public FRigInfluenceEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x00066DA4 File Offset: 0x00064FA4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigInfluenceEntry(Pointer, false, true);
		}

		// Token: 0x06004510 RID: 17680 RVA: 0x00066DAE File Offset: 0x00064FAE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigInfluenceEntry(Pointer, MemoryOwner);
		}

		// Token: 0x040021A0 RID: 8608
		public const string __ObjectPath = "/Script/ControlRig.RigInfluenceEntry";

		// Token: 0x040021A1 RID: 8609
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021A2 RID: 8610
		internal static int __PropertyOffset_Source;

		// Token: 0x040021A3 RID: 8611
		[Nullable(2)]
		private FRigElementKey _Source;

		// Token: 0x040021A4 RID: 8612
		internal static int __PropertyOffset_AffectedList;

		// Token: 0x040021A5 RID: 8613
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigElementKey> _AffectedList;
	}
}
