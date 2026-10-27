using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002C2 RID: 706
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimationCore.NodeChain")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNodeChain : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600272D RID: 10029 RVA: 0x0003AC80 File Offset: 0x00038E80
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNodeChain._ScriptStructPtr != 0) ? FNodeChain._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.NodeChain", ref FNodeChain._ScriptStructPtr);
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x0600272E RID: 10030 RVA: 0x0003ACA4 File Offset: 0x00038EA4
		// (set) Token: 0x0600272F RID: 10031 RVA: 0x0003ACE7 File Offset: 0x00038EE7
		public TArray<FName> Nodes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Nodes) == null)
				{
					result = (this._Nodes = new TArray<FName>(base.NativePtr + (IntPtr)FNodeChain.__PropertyOffset_Nodes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Nodes.CopyAssign(value);
			}
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x0003ACF5 File Offset: 0x00038EF5
		public FNodeChain()
		{
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x0003ACFD File Offset: 0x00038EFD
		public FNodeChain(TArray<FName> Nodes)
		{
			this.Nodes = Nodes;
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x0003AD0C File Offset: 0x00038F0C
		protected override IntPtr GetUStructPtr()
		{
			return FNodeChain.StaticStruct();
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x0003AD18 File Offset: 0x00038F18
		[NullableContext(2)]
		public FNodeChain(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x0003AD22 File Offset: 0x00038F22
		public FNodeChain(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x0003AD2D File Offset: 0x00038F2D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNodeChain(Pointer, false, true);
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x0003AD37 File Offset: 0x00038F37
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNodeChain(Pointer, MemoryOwner);
		}

		// Token: 0x04000F6F RID: 3951
		public const string __ObjectPath = "/Script/AnimationCore.NodeChain";

		// Token: 0x04000F70 RID: 3952
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F71 RID: 3953
		internal static int __PropertyOffset_Nodes;

		// Token: 0x04000F72 RID: 3954
		[Nullable(2)]
		private TArray<FName> _Nodes;
	}
}
