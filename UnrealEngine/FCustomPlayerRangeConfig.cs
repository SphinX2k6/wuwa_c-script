using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001853 RID: 6227
	[UnrealObjectPath("/Script/KuroGameBudget.CustomPlayerRangeConfig")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FCustomPlayerRangeConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016EFF RID: 93951 RVA: 0x002177D6 File Offset: 0x002159D6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCustomPlayerRangeConfig._ScriptStructPtr != 0) ? FCustomPlayerRangeConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameBudget.CustomPlayerRangeConfig", ref FCustomPlayerRangeConfig._ScriptStructPtr);
		}

		// Token: 0x17005C74 RID: 23668
		// (get) Token: 0x06016F00 RID: 93952 RVA: 0x002177FA File Offset: 0x002159FA
		// (set) Token: 0x06016F01 RID: 93953 RVA: 0x0021780E File Offset: 0x00215A0E
		public unsafe FName RangeName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCustomPlayerRangeConfig.__PropertyOffset_RangeName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomPlayerRangeConfig.__PropertyOffset_RangeName) = value;
			}
		}

		// Token: 0x17005C75 RID: 23669
		// (get) Token: 0x06016F02 RID: 93954 RVA: 0x00217823 File Offset: 0x00215A23
		// (set) Token: 0x06016F03 RID: 93955 RVA: 0x00217833 File Offset: 0x00215A33
		public unsafe float EnterRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCustomPlayerRangeConfig.__PropertyOffset_EnterRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomPlayerRangeConfig.__PropertyOffset_EnterRange) = value;
			}
		}

		// Token: 0x17005C76 RID: 23670
		// (get) Token: 0x06016F04 RID: 93956 RVA: 0x00217844 File Offset: 0x00215A44
		// (set) Token: 0x06016F05 RID: 93957 RVA: 0x00217854 File Offset: 0x00215A54
		public unsafe float LeaveRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCustomPlayerRangeConfig.__PropertyOffset_LeaveRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomPlayerRangeConfig.__PropertyOffset_LeaveRange) = value;
			}
		}

		// Token: 0x06016F06 RID: 93958 RVA: 0x00217865 File Offset: 0x00215A65
		public FCustomPlayerRangeConfig()
		{
		}

		// Token: 0x06016F07 RID: 93959 RVA: 0x0021786D File Offset: 0x00215A6D
		public FCustomPlayerRangeConfig(FName RangeName, float EnterRange, float LeaveRange)
		{
			this.RangeName = RangeName;
			this.EnterRange = EnterRange;
			this.LeaveRange = LeaveRange;
		}

		// Token: 0x06016F08 RID: 93960 RVA: 0x0021788A File Offset: 0x00215A8A
		protected override IntPtr GetUStructPtr()
		{
			return FCustomPlayerRangeConfig.StaticStruct();
		}

		// Token: 0x06016F09 RID: 93961 RVA: 0x00217896 File Offset: 0x00215A96
		[NullableContext(2)]
		public FCustomPlayerRangeConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016F0A RID: 93962 RVA: 0x002178A0 File Offset: 0x00215AA0
		public FCustomPlayerRangeConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016F0B RID: 93963 RVA: 0x002178AB File Offset: 0x00215AAB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCustomPlayerRangeConfig(Pointer, false, true);
		}

		// Token: 0x06016F0C RID: 93964 RVA: 0x002178B5 File Offset: 0x00215AB5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCustomPlayerRangeConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400C75D RID: 51037
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameBudget.CustomPlayerRangeConfig";

		// Token: 0x0400C75E RID: 51038
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C75F RID: 51039
		internal static int __PropertyOffset_RangeName;

		// Token: 0x0400C760 RID: 51040
		internal static int __PropertyOffset_EnterRange;

		// Token: 0x0400C761 RID: 51041
		internal static int __PropertyOffset_LeaveRange;
	}
}
