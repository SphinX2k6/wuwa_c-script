using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000339 RID: 825
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.PositionHistory")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FPositionHistory : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002DF1 RID: 11761 RVA: 0x00046874 File Offset: 0x00044A74
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPositionHistory._ScriptStructPtr != 0) ? FPositionHistory._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.PositionHistory", ref FPositionHistory._ScriptStructPtr);
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06002DF2 RID: 11762 RVA: 0x00046898 File Offset: 0x00044A98
		// (set) Token: 0x06002DF3 RID: 11763 RVA: 0x000468DB File Offset: 0x00044ADB
		public TArray<FVector> Positions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Positions) == null)
				{
					result = (this._Positions = new TArray<FVector>(base.NativePtr + (IntPtr)FPositionHistory.__PropertyOffset_Positions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Positions.CopyAssign(value);
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06002DF4 RID: 11764 RVA: 0x000468E9 File Offset: 0x00044AE9
		// (set) Token: 0x06002DF5 RID: 11765 RVA: 0x000468F9 File Offset: 0x00044AF9
		public unsafe float Range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPositionHistory.__PropertyOffset_Range);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPositionHistory.__PropertyOffset_Range) = value;
			}
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x0004690A File Offset: 0x00044B0A
		public FPositionHistory()
		{
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x00046912 File Offset: 0x00044B12
		public FPositionHistory(TArray<FVector> Positions, float Range)
		{
			this.Positions = Positions;
			this.Range = Range;
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x00046928 File Offset: 0x00044B28
		protected override IntPtr GetUStructPtr()
		{
			return FPositionHistory.StaticStruct();
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x00046934 File Offset: 0x00044B34
		[NullableContext(2)]
		public FPositionHistory(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x0004693E File Offset: 0x00044B3E
		public FPositionHistory(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x00046949 File Offset: 0x00044B49
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPositionHistory(Pointer, false, true);
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x00046953 File Offset: 0x00044B53
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPositionHistory(Pointer, MemoryOwner);
		}

		// Token: 0x040013AF RID: 5039
		public const string __ObjectPath = "/Script/AnimGraphRuntime.PositionHistory";

		// Token: 0x040013B0 RID: 5040
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040013B1 RID: 5041
		internal static int __PropertyOffset_Positions;

		// Token: 0x040013B2 RID: 5042
		[Nullable(2)]
		private TArray<FVector> _Positions;

		// Token: 0x040013B3 RID: 5043
		internal static int __PropertyOffset_Range;
	}
}
