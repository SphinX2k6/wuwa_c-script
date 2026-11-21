using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002E1 RID: 737
	[UnrealObjectPath("/Script/KuroAnim.ClimbInfoStruct")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FClimbInfoStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004FAC RID: 20396 RVA: 0x0006F8E1 File Offset: 0x0006DAE1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClimbInfoStruct._ScriptStructPtr != 0) ? FClimbInfoStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.ClimbInfoStruct", ref FClimbInfoStruct._ScriptStructPtr);
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06004FAD RID: 20397 RVA: 0x0006F905 File Offset: 0x0006DB05
		// (set) Token: 0x06004FAE RID: 20398 RVA: 0x0006F915 File Offset: 0x0006DB15
		public unsafe bool IsClimbMoving
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClimbInfoStruct.__PropertyOffset_IsClimbMoving) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClimbInfoStruct.__PropertyOffset_IsClimbMoving) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06004FAF RID: 20399 RVA: 0x0006F926 File Offset: 0x0006DB26
		// (set) Token: 0x06004FB0 RID: 20400 RVA: 0x0006F93A File Offset: 0x0006DB3A
		public unsafe FVector2D ClimbInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClimbInfoStruct.__PropertyOffset_ClimbInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClimbInfoStruct.__PropertyOffset_ClimbInput) = value;
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06004FB1 RID: 20401 RVA: 0x0006F94F File Offset: 0x0006DB4F
		// (set) Token: 0x06004FB2 RID: 20402 RVA: 0x0006F95F File Offset: 0x0006DB5F
		public unsafe float OnWallAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClimbInfoStruct.__PropertyOffset_OnWallAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClimbInfoStruct.__PropertyOffset_OnWallAngle) = value;
			}
		}

		// Token: 0x06004FB3 RID: 20403 RVA: 0x0006F970 File Offset: 0x0006DB70
		public FClimbInfoStruct()
		{
		}

		// Token: 0x06004FB4 RID: 20404 RVA: 0x0006F978 File Offset: 0x0006DB78
		protected override IntPtr GetUStructPtr()
		{
			return FClimbInfoStruct.StaticStruct();
		}

		// Token: 0x06004FB5 RID: 20405 RVA: 0x0006F984 File Offset: 0x0006DB84
		[NullableContext(2)]
		public FClimbInfoStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004FB6 RID: 20406 RVA: 0x0006F98E File Offset: 0x0006DB8E
		public FClimbInfoStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004FB7 RID: 20407 RVA: 0x0006F999 File Offset: 0x0006DB99
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClimbInfoStruct(Pointer, false, true);
		}

		// Token: 0x06004FB8 RID: 20408 RVA: 0x0006F9A3 File Offset: 0x0006DBA3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClimbInfoStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04001FFF RID: 8191
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.ClimbInfoStruct";

		// Token: 0x04002000 RID: 8192
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002001 RID: 8193
		internal static int __PropertyOffset_IsClimbMoving;

		// Token: 0x04002002 RID: 8194
		internal static int __PropertyOffset_ClimbInput;

		// Token: 0x04002003 RID: 8195
		internal static int __PropertyOffset_OnWallAngle;
	}
}
