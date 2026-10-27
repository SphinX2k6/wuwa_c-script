using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000A47 RID: 2631
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EdGraph")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UEdGraph : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008EBF RID: 36543 RVA: 0x000CC155 File Offset: 0x000CA355
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEdGraph._ClassPtr;
		}

		// Token: 0x06008EC0 RID: 36544 RVA: 0x000CC164 File Offset: 0x000CA364
		public UEdGraph() : this(BuiltinUtils.AllocNativeUObject(UEdGraph.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008EC1 RID: 36545 RVA: 0x000CC18C File Offset: 0x000CA38C
		public UEdGraph(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEdGraph.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700219F RID: 8607
		// (get) Token: 0x06008EC2 RID: 36546 RVA: 0x000CC1BF File Offset: 0x000CA3BF
		// (set) Token: 0x06008EC3 RID: 36547 RVA: 0x000CC1D3 File Offset: 0x000CA3D3
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEdGraphSchema> Schema
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEdGraph.__PropertyOffset_Schema);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEdGraph.__PropertyOffset_Schema) = value;
			}
		}

		// Token: 0x170021A0 RID: 8608
		// (get) Token: 0x06008EC4 RID: 36548 RVA: 0x000CC1E8 File Offset: 0x000CA3E8
		// (set) Token: 0x06008EC5 RID: 36549 RVA: 0x000CC221 File Offset: 0x000CA421
		public TArray<UEdGraphNode> Nodes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UEdGraphNode> result;
				if ((result = this._Nodes) == null)
				{
					result = (this._Nodes = new TArray<UEdGraphNode>(base.NativePtr + (IntPtr)UEdGraph.__PropertyOffset_Nodes, this));
				}
				return result;
			}
			set
			{
				this.Nodes.CopyAssign(value);
			}
		}

		// Token: 0x170021A1 RID: 8609
		// (get) Token: 0x06008EC6 RID: 36550 RVA: 0x000CC22F File Offset: 0x000CA42F
		// (set) Token: 0x06008EC7 RID: 36551 RVA: 0x000CC248 File Offset: 0x000CA448
		public unsafe bool bEditable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEdGraph.__PropertyOffset_bEditable) & UEdGraph.__PropertyMask_bEditable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEdGraph.__PropertyOffset_bEditable) = ((*(base.NativePtr + (IntPtr)UEdGraph.__PropertyOffset_bEditable) & ~UEdGraph.__PropertyMask_bEditable) | (value ? UEdGraph.__PropertyMask_bEditable : 0));
			}
		}

		// Token: 0x170021A2 RID: 8610
		// (get) Token: 0x06008EC8 RID: 36552 RVA: 0x000CC278 File Offset: 0x000CA478
		// (set) Token: 0x06008EC9 RID: 36553 RVA: 0x000CC291 File Offset: 0x000CA491
		public unsafe bool bAllowDeletion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEdGraph.__PropertyOffset_bAllowDeletion) & UEdGraph.__PropertyMask_bAllowDeletion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEdGraph.__PropertyOffset_bAllowDeletion) = ((*(base.NativePtr + (IntPtr)UEdGraph.__PropertyOffset_bAllowDeletion) & ~UEdGraph.__PropertyMask_bAllowDeletion) | (value ? UEdGraph.__PropertyMask_bAllowDeletion : 0));
			}
		}

		// Token: 0x170021A3 RID: 8611
		// (get) Token: 0x06008ECA RID: 36554 RVA: 0x000CC2C1 File Offset: 0x000CA4C1
		// (set) Token: 0x06008ECB RID: 36555 RVA: 0x000CC2DA File Offset: 0x000CA4DA
		public unsafe bool bAllowRenaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEdGraph.__PropertyOffset_bAllowRenaming) & UEdGraph.__PropertyMask_bAllowRenaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEdGraph.__PropertyOffset_bAllowRenaming) = ((*(base.NativePtr + (IntPtr)UEdGraph.__PropertyOffset_bAllowRenaming) & ~UEdGraph.__PropertyMask_bAllowRenaming) | (value ? UEdGraph.__PropertyMask_bAllowRenaming : 0));
			}
		}

		// Token: 0x06008ECC RID: 36556 RVA: 0x000CC30A File Offset: 0x000CA50A
		static UEdGraph()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.EdGraph");
		}

		// Token: 0x06008ECD RID: 36557 RVA: 0x000CC318 File Offset: 0x000CA518
		protected UEdGraph(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400466A RID: 18026
		public new const string __ObjectPath = "/Script/Engine.EdGraph";

		// Token: 0x0400466B RID: 18027
		private static IntPtr _ClassPtr;

		// Token: 0x0400466C RID: 18028
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400466D RID: 18029
		internal static int __PropertyOffset_Schema;

		// Token: 0x0400466E RID: 18030
		internal static int __PropertyOffset_Nodes;

		// Token: 0x0400466F RID: 18031
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UEdGraphNode> _Nodes;

		// Token: 0x04004670 RID: 18032
		internal static int __PropertyOffset_bEditable;

		// Token: 0x04004671 RID: 18033
		internal static byte __PropertyMask_bEditable;

		// Token: 0x04004672 RID: 18034
		internal static int __PropertyOffset_bAllowDeletion;

		// Token: 0x04004673 RID: 18035
		internal static byte __PropertyMask_bAllowDeletion;

		// Token: 0x04004674 RID: 18036
		internal static int __PropertyOffset_bAllowRenaming;

		// Token: 0x04004675 RID: 18037
		internal static byte __PropertyMask_bAllowRenaming;
	}
}
