using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002E2 RID: 738
	[UnrealObjectPath("/Script/KuroAnim.ClimbStateStruct")]
	[UnrealStructLayout(3, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 3)]
	public class FClimbStateStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004FB9 RID: 20409 RVA: 0x0006F9AC File Offset: 0x0006DBAC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClimbStateStruct._ScriptStructPtr != 0) ? FClimbStateStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.ClimbStateStruct", ref FClimbStateStruct._ScriptStructPtr);
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06004FBA RID: 20410 RVA: 0x0006F9D0 File Offset: 0x0006DBD0
		// (set) Token: 0x06004FBB RID: 20411 RVA: 0x0006F9E0 File Offset: 0x0006DBE0
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

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06004FBC RID: 20412 RVA: 0x0006F9F1 File Offset: 0x0006DBF1
		// (set) Token: 0x06004FBD RID: 20413 RVA: 0x0006FA01 File Offset: 0x0006DC01
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

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06004FBE RID: 20414 RVA: 0x0006FA12 File Offset: 0x0006DC12
		// (set) Token: 0x06004FBF RID: 20415 RVA: 0x0006FA22 File Offset: 0x0006DC22
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

		// Token: 0x06004FC0 RID: 20416 RVA: 0x0006FA33 File Offset: 0x0006DC33
		public FClimbStateStruct()
		{
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x0006FA3B File Offset: 0x0006DC3B
		protected override IntPtr GetUStructPtr()
		{
			return FClimbStateStruct.StaticStruct();
		}

		// Token: 0x06004FC2 RID: 20418 RVA: 0x0006FA47 File Offset: 0x0006DC47
		[NullableContext(2)]
		public FClimbStateStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004FC3 RID: 20419 RVA: 0x0006FA51 File Offset: 0x0006DC51
		public FClimbStateStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004FC4 RID: 20420 RVA: 0x0006FA5C File Offset: 0x0006DC5C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClimbStateStruct(Pointer, false, true);
		}

		// Token: 0x06004FC5 RID: 20421 RVA: 0x0006FA66 File Offset: 0x0006DC66
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClimbStateStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04002004 RID: 8196
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.ClimbStateStruct";

		// Token: 0x04002005 RID: 8197
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002006 RID: 8198
		internal static int __PropertyOffset_ClimbState;

		// Token: 0x04002007 RID: 8199
		internal static int __PropertyOffset_EnterClimbType;

		// Token: 0x04002008 RID: 8200
		internal static int __PropertyOffset_ExitClimbType;
	}
}
