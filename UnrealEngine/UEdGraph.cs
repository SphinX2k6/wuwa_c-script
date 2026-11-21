using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001DC RID: 476
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EdGraph")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UEdGraph : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002170 RID: 8560 RVA: 0x00030FF9 File Offset: 0x0002F1F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEdGraph._ClassPtr;
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x00031008 File Offset: 0x0002F208
		public UEdGraph() : this(BuiltinUtils.AllocNativeUObject(UEdGraph.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x00031030 File Offset: 0x0002F230
		public UEdGraph(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEdGraph.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x00031064 File Offset: 0x0002F264
		// (set) Token: 0x06002174 RID: 8564 RVA: 0x0003109D File Offset: 0x0002F29D
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

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x000310AB File Offset: 0x0002F2AB
		// (set) Token: 0x06002176 RID: 8566 RVA: 0x000310C4 File Offset: 0x0002F2C4
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

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x000310F4 File Offset: 0x0002F2F4
		// (set) Token: 0x06002178 RID: 8568 RVA: 0x0003110D File Offset: 0x0002F30D
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

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x0003113D File Offset: 0x0002F33D
		// (set) Token: 0x0600217A RID: 8570 RVA: 0x00031156 File Offset: 0x0002F356
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

		// Token: 0x0600217B RID: 8571 RVA: 0x00031186 File Offset: 0x0002F386
		static UEdGraph()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.EdGraph");
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00031194 File Offset: 0x0002F394
		protected UEdGraph(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000BAB RID: 2987
		public new const string __ObjectPath = "/Script/Engine.EdGraph";

		// Token: 0x04000BAC RID: 2988
		private static IntPtr _ClassPtr;

		// Token: 0x04000BAD RID: 2989
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000BAE RID: 2990
		internal static int __PropertyOffset_Nodes;

		// Token: 0x04000BAF RID: 2991
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UEdGraphNode> _Nodes;

		// Token: 0x04000BB0 RID: 2992
		internal static int __PropertyOffset_bEditable;

		// Token: 0x04000BB1 RID: 2993
		internal static byte __PropertyMask_bEditable;

		// Token: 0x04000BB2 RID: 2994
		internal static int __PropertyOffset_bAllowDeletion;

		// Token: 0x04000BB3 RID: 2995
		internal static byte __PropertyMask_bAllowDeletion;

		// Token: 0x04000BB4 RID: 2996
		internal static int __PropertyOffset_bAllowRenaming;

		// Token: 0x04000BB5 RID: 2997
		internal static byte __PropertyMask_bAllowRenaming;
	}
}
