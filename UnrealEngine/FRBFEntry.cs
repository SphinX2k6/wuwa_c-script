using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200033B RID: 827
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.RBFEntry")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRBFEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002E13 RID: 11795 RVA: 0x00046B2D File Offset: 0x00044D2D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRBFEntry._ScriptStructPtr != 0) ? FRBFEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.RBFEntry", ref FRBFEntry._ScriptStructPtr);
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06002E14 RID: 11796 RVA: 0x00046B54 File Offset: 0x00044D54
		// (set) Token: 0x06002E15 RID: 11797 RVA: 0x00046B97 File Offset: 0x00044D97
		public TArray<float> Values
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<float>(base.NativePtr + (IntPtr)FRBFEntry.__PropertyOffset_Values, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x00046BA5 File Offset: 0x00044DA5
		public FRBFEntry()
		{
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x00046BAD File Offset: 0x00044DAD
		public FRBFEntry(TArray<float> Values)
		{
			this.Values = Values;
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x00046BBC File Offset: 0x00044DBC
		protected override IntPtr GetUStructPtr()
		{
			return FRBFEntry.StaticStruct();
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x00046BC8 File Offset: 0x00044DC8
		[NullableContext(2)]
		public FRBFEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x00046BD2 File Offset: 0x00044DD2
		public FRBFEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x00046BDD File Offset: 0x00044DDD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRBFEntry(Pointer, false, true);
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x00046BE7 File Offset: 0x00044DE7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRBFEntry(Pointer, MemoryOwner);
		}

		// Token: 0x040013BE RID: 5054
		public const string __ObjectPath = "/Script/AnimGraphRuntime.RBFEntry";

		// Token: 0x040013BF RID: 5055
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040013C0 RID: 5056
		internal static int __PropertyOffset_Values;

		// Token: 0x040013C1 RID: 5057
		[Nullable(2)]
		private TArray<float> _Values;
	}
}
