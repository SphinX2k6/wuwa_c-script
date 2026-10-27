using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000518 RID: 1304
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigControlHierarchy")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class FRigControlHierarchy : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004455 RID: 17493 RVA: 0x00065D88 File Offset: 0x00063F88
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigControlHierarchy._ScriptStructPtr != 0) ? FRigControlHierarchy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigControlHierarchy", ref FRigControlHierarchy._ScriptStructPtr);
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x06004456 RID: 17494 RVA: 0x00065DAC File Offset: 0x00063FAC
		// (set) Token: 0x06004457 RID: 17495 RVA: 0x00065DEF File Offset: 0x00063FEF
		public TArray<FRigControl> Controls
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigControl> result;
				if ((result = this._Controls) == null)
				{
					result = (this._Controls = new TArray<FRigControl>(base.NativePtr + (IntPtr)FRigControlHierarchy.__PropertyOffset_Controls, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Controls.CopyAssign(value);
			}
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x06004458 RID: 17496 RVA: 0x00065E00 File Offset: 0x00064000
		// (set) Token: 0x06004459 RID: 17497 RVA: 0x00065E43 File Offset: 0x00064043
		public TMap<FName, int> NameToIndexMapping
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._NameToIndexMapping) == null)
				{
					result = (this._NameToIndexMapping = new TMap<FName, int>(base.NativePtr + (IntPtr)FRigControlHierarchy.__PropertyOffset_NameToIndexMapping, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NameToIndexMapping.CopyAssign(value);
			}
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x0600445A RID: 17498 RVA: 0x00065E54 File Offset: 0x00064054
		// (set) Token: 0x0600445B RID: 17499 RVA: 0x00065E97 File Offset: 0x00064097
		public TArray<FName> Selection
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Selection) == null)
				{
					result = (this._Selection = new TArray<FName>(base.NativePtr + (IntPtr)FRigControlHierarchy.__PropertyOffset_Selection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Selection.CopyAssign(value);
			}
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x00065EA5 File Offset: 0x000640A5
		public FRigControlHierarchy()
		{
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x00065EAD File Offset: 0x000640AD
		public FRigControlHierarchy(TArray<FRigControl> Controls, TMap<FName, int> NameToIndexMapping, TArray<FName> Selection)
		{
			this.Controls = Controls;
			this.NameToIndexMapping = NameToIndexMapping;
			this.Selection = Selection;
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x00065ECA File Offset: 0x000640CA
		protected override IntPtr GetUStructPtr()
		{
			return FRigControlHierarchy.StaticStruct();
		}

		// Token: 0x0600445F RID: 17503 RVA: 0x00065ED6 File Offset: 0x000640D6
		[NullableContext(2)]
		public FRigControlHierarchy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x00065EE0 File Offset: 0x000640E0
		public FRigControlHierarchy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x00065EEB File Offset: 0x000640EB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigControlHierarchy(Pointer, false, true);
		}

		// Token: 0x06004462 RID: 17506 RVA: 0x00065EF5 File Offset: 0x000640F5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigControlHierarchy(Pointer, MemoryOwner);
		}

		// Token: 0x04002150 RID: 8528
		public const string __ObjectPath = "/Script/ControlRig.RigControlHierarchy";

		// Token: 0x04002151 RID: 8529
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002152 RID: 8530
		internal static int __PropertyOffset_Controls;

		// Token: 0x04002153 RID: 8531
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigControl> _Controls;

		// Token: 0x04002154 RID: 8532
		internal static int __PropertyOffset_NameToIndexMapping;

		// Token: 0x04002155 RID: 8533
		[Nullable(2)]
		private TMap<FName, int> _NameToIndexMapping;

		// Token: 0x04002156 RID: 8534
		internal static int __PropertyOffset_Selection;

		// Token: 0x04002157 RID: 8535
		[Nullable(2)]
		private TArray<FName> _Selection;
	}
}
