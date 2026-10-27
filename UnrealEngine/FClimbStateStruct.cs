using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200162F RID: 5679
	[UnrealObjectPath("/Script/KuroAnim.ClimbStateStruct")]
	[UnrealStructLayout(3, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 3)]
	public class FClimbStateStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060148CA RID: 84170 RVA: 0x001E3AA3 File Offset: 0x001E1CA3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClimbStateStruct._ScriptStructPtr != 0) ? FClimbStateStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.ClimbStateStruct", ref FClimbStateStruct._ScriptStructPtr);
		}

		// Token: 0x170050EB RID: 20715
		// (get) Token: 0x060148CB RID: 84171 RVA: 0x001E3AC7 File Offset: 0x001E1CC7
		// (set) Token: 0x060148CC RID: 84172 RVA: 0x001E3AD7 File Offset: 0x001E1CD7
		public unsafe EClimbStateType ClimbState
		{
			get
			{
				return (EClimbStateType)(*(base.NativePtr + (IntPtr)FClimbStateStruct.__PropertyOffset_ClimbState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClimbStateStruct.__PropertyOffset_ClimbState) = (byte)value;
			}
		}

		// Token: 0x170050EC RID: 20716
		// (get) Token: 0x060148CD RID: 84173 RVA: 0x001E3AE8 File Offset: 0x001E1CE8
		// (set) Token: 0x060148CE RID: 84174 RVA: 0x001E3AF8 File Offset: 0x001E1CF8
		public unsafe EEnterClimbType EnterClimbType
		{
			get
			{
				return (EEnterClimbType)(*(base.NativePtr + (IntPtr)FClimbStateStruct.__PropertyOffset_EnterClimbType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClimbStateStruct.__PropertyOffset_EnterClimbType) = (byte)value;
			}
		}

		// Token: 0x170050ED RID: 20717
		// (get) Token: 0x060148CF RID: 84175 RVA: 0x001E3B09 File Offset: 0x001E1D09
		// (set) Token: 0x060148D0 RID: 84176 RVA: 0x001E3B19 File Offset: 0x001E1D19
		public unsafe EExitClimbType ExitClimbType
		{
			get
			{
				return (EExitClimbType)(*(base.NativePtr + (IntPtr)FClimbStateStruct.__PropertyOffset_ExitClimbType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClimbStateStruct.__PropertyOffset_ExitClimbType) = (byte)value;
			}
		}

		// Token: 0x060148D1 RID: 84177 RVA: 0x001E3B2A File Offset: 0x001E1D2A
		public FClimbStateStruct()
		{
		}

		// Token: 0x060148D2 RID: 84178 RVA: 0x001E3B32 File Offset: 0x001E1D32
		public FClimbStateStruct(EClimbStateType ClimbState, EEnterClimbType EnterClimbType, EExitClimbType ExitClimbType)
		{
			this.ClimbState = ClimbState;
			this.EnterClimbType = EnterClimbType;
			this.ExitClimbType = ExitClimbType;
		}

		// Token: 0x060148D3 RID: 84179 RVA: 0x001E3B4F File Offset: 0x001E1D4F
		protected override IntPtr GetUStructPtr()
		{
			return FClimbStateStruct.StaticStruct();
		}

		// Token: 0x060148D4 RID: 84180 RVA: 0x001E3B5B File Offset: 0x001E1D5B
		[NullableContext(2)]
		public FClimbStateStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060148D5 RID: 84181 RVA: 0x001E3B65 File Offset: 0x001E1D65
		public FClimbStateStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060148D6 RID: 84182 RVA: 0x001E3B70 File Offset: 0x001E1D70
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClimbStateStruct(Pointer, false, true);
		}

		// Token: 0x060148D7 RID: 84183 RVA: 0x001E3B7A File Offset: 0x001E1D7A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClimbStateStruct(Pointer, MemoryOwner);
		}

		// Token: 0x0400B2C6 RID: 45766
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.ClimbStateStruct";

		// Token: 0x0400B2C7 RID: 45767
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B2C8 RID: 45768
		internal static int __PropertyOffset_ClimbState;

		// Token: 0x0400B2C9 RID: 45769
		internal static int __PropertyOffset_EnterClimbType;

		// Token: 0x0400B2CA RID: 45770
		internal static int __PropertyOffset_ExitClimbType;
	}
}
