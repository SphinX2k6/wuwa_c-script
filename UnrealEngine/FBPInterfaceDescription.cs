using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008EC RID: 2284
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BPInterfaceDescription")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FBPInterfaceDescription : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007D45 RID: 32069 RVA: 0x000B38BB File Offset: 0x000B1ABB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBPInterfaceDescription._ScriptStructPtr != 0) ? FBPInterfaceDescription._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BPInterfaceDescription", ref FBPInterfaceDescription._ScriptStructPtr);
		}

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x06007D46 RID: 32070 RVA: 0x000B38DF File Offset: 0x000B1ADF
		// (set) Token: 0x06007D47 RID: 32071 RVA: 0x000B38F3 File Offset: 0x000B1AF3
		public unsafe UClassStackOnlyPtr Interface
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBPInterfaceDescription.__PropertyOffset_Interface);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBPInterfaceDescription.__PropertyOffset_Interface) = value;
			}
		}

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x06007D48 RID: 32072 RVA: 0x000B3908 File Offset: 0x000B1B08
		// (set) Token: 0x06007D49 RID: 32073 RVA: 0x000B394B File Offset: 0x000B1B4B
		public TArray<UEdGraph> Graphs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UEdGraph> result;
				if ((result = this._Graphs) == null)
				{
					result = (this._Graphs = new TArray<UEdGraph>(base.NativePtr + (IntPtr)FBPInterfaceDescription.__PropertyOffset_Graphs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Graphs.CopyAssign(value);
			}
		}

		// Token: 0x06007D4A RID: 32074 RVA: 0x000B3959 File Offset: 0x000B1B59
		public FBPInterfaceDescription()
		{
		}

		// Token: 0x06007D4B RID: 32075 RVA: 0x000B3961 File Offset: 0x000B1B61
		public FBPInterfaceDescription(UClassStackOnlyPtr Interface, TArray<UEdGraph> Graphs)
		{
			this.Interface = Interface;
			this.Graphs = Graphs;
		}

		// Token: 0x06007D4C RID: 32076 RVA: 0x000B3977 File Offset: 0x000B1B77
		protected override IntPtr GetUStructPtr()
		{
			return FBPInterfaceDescription.StaticStruct();
		}

		// Token: 0x06007D4D RID: 32077 RVA: 0x000B3983 File Offset: 0x000B1B83
		[NullableContext(2)]
		public FBPInterfaceDescription(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007D4E RID: 32078 RVA: 0x000B398D File Offset: 0x000B1B8D
		public FBPInterfaceDescription(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007D4F RID: 32079 RVA: 0x000B3998 File Offset: 0x000B1B98
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBPInterfaceDescription(Pointer, false, true);
		}

		// Token: 0x06007D50 RID: 32080 RVA: 0x000B39A2 File Offset: 0x000B1BA2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBPInterfaceDescription(Pointer, MemoryOwner);
		}

		// Token: 0x04003C07 RID: 15367
		public const string __ObjectPath = "/Script/Engine.BPInterfaceDescription";

		// Token: 0x04003C08 RID: 15368
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003C09 RID: 15369
		internal static int __PropertyOffset_Interface;

		// Token: 0x04003C0A RID: 15370
		internal static int __PropertyOffset_Graphs;

		// Token: 0x04003C0B RID: 15371
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UEdGraph> _Graphs;
	}
}
