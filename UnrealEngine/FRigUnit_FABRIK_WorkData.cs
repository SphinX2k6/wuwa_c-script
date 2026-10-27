using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005A7 RID: 1447
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_FABRIK_WorkData")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRigUnit_FABRIK_WorkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004DB3 RID: 19891 RVA: 0x00072BA0 File Offset: 0x00070DA0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_FABRIK_WorkData._ScriptStructPtr != 0) ? FRigUnit_FABRIK_WorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_FABRIK_WorkData", ref FRigUnit_FABRIK_WorkData._ScriptStructPtr);
		}

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x06004DB4 RID: 19892 RVA: 0x00072BC4 File Offset: 0x00070DC4
		// (set) Token: 0x06004DB5 RID: 19893 RVA: 0x00072C07 File Offset: 0x00070E07
		public TArray<FFABRIKChainLink> Chain
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFABRIKChainLink> result;
				if ((result = this._Chain) == null)
				{
					result = (this._Chain = new TArray<FFABRIKChainLink>(base.NativePtr + (IntPtr)FRigUnit_FABRIK_WorkData.__PropertyOffset_Chain, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Chain.CopyAssign(value);
			}
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x06004DB6 RID: 19894 RVA: 0x00072C18 File Offset: 0x00070E18
		// (set) Token: 0x06004DB7 RID: 19895 RVA: 0x00072C5B File Offset: 0x00070E5B
		public TArray<FCachedRigElement> CachedItems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCachedRigElement> result;
				if ((result = this._CachedItems) == null)
				{
					result = (this._CachedItems = new TArray<FCachedRigElement>(base.NativePtr + (IntPtr)FRigUnit_FABRIK_WorkData.__PropertyOffset_CachedItems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CachedItems.CopyAssign(value);
			}
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x06004DB8 RID: 19896 RVA: 0x00072C6C File Offset: 0x00070E6C
		// (set) Token: 0x06004DB9 RID: 19897 RVA: 0x00072CAF File Offset: 0x00070EAF
		public FCachedRigElement CachedEffector
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedEffector) == null)
				{
					result = (this._CachedEffector = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_FABRIK_WorkData.__PropertyOffset_CachedEffector, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_FABRIK_WorkData.__PropertyOffset_CachedEffector, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004DBA RID: 19898 RVA: 0x00072CD0 File Offset: 0x00070ED0
		public FRigUnit_FABRIK_WorkData()
		{
		}

		// Token: 0x06004DBB RID: 19899 RVA: 0x00072CD8 File Offset: 0x00070ED8
		public FRigUnit_FABRIK_WorkData(TArray<FFABRIKChainLink> Chain, TArray<FCachedRigElement> CachedItems, FCachedRigElement CachedEffector)
		{
			this.Chain = Chain;
			this.CachedItems = CachedItems;
			this.CachedEffector = CachedEffector;
		}

		// Token: 0x06004DBC RID: 19900 RVA: 0x00072CF5 File Offset: 0x00070EF5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_FABRIK_WorkData.StaticStruct();
		}

		// Token: 0x06004DBD RID: 19901 RVA: 0x00072D01 File Offset: 0x00070F01
		[NullableContext(2)]
		public FRigUnit_FABRIK_WorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004DBE RID: 19902 RVA: 0x00072D0B File Offset: 0x00070F0B
		public FRigUnit_FABRIK_WorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004DBF RID: 19903 RVA: 0x00072D16 File Offset: 0x00070F16
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_FABRIK_WorkData(Pointer, false, true);
		}

		// Token: 0x06004DC0 RID: 19904 RVA: 0x00072D20 File Offset: 0x00070F20
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_FABRIK_WorkData(Pointer, MemoryOwner);
		}

		// Token: 0x04002583 RID: 9603
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_FABRIK_WorkData";

		// Token: 0x04002584 RID: 9604
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002585 RID: 9605
		internal static int __PropertyOffset_Chain;

		// Token: 0x04002586 RID: 9606
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFABRIKChainLink> _Chain;

		// Token: 0x04002587 RID: 9607
		internal static int __PropertyOffset_CachedItems;

		// Token: 0x04002588 RID: 9608
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCachedRigElement> _CachedItems;

		// Token: 0x04002589 RID: 9609
		internal static int __PropertyOffset_CachedEffector;

		// Token: 0x0400258A RID: 9610
		[Nullable(2)]
		private FCachedRigElement _CachedEffector;
	}
}
