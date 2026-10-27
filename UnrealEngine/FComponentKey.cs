using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200095A RID: 2394
	[UnrealObjectPath("/Script/Engine.ComponentKey")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FComponentKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600875F RID: 34655 RVA: 0x000C1A2A File Offset: 0x000BFC2A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FComponentKey._ScriptStructPtr != 0) ? FComponentKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ComponentKey", ref FComponentKey._ScriptStructPtr);
		}

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x06008760 RID: 34656 RVA: 0x000C1A4E File Offset: 0x000BFC4E
		// (set) Token: 0x06008761 RID: 34657 RVA: 0x000C1A62 File Offset: 0x000BFC62
		public unsafe UClassStackOnlyPtr OwnerClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComponentKey.__PropertyOffset_OwnerClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComponentKey.__PropertyOffset_OwnerClass) = value;
			}
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x06008762 RID: 34658 RVA: 0x000C1A77 File Offset: 0x000BFC77
		// (set) Token: 0x06008763 RID: 34659 RVA: 0x000C1A8B File Offset: 0x000BFC8B
		public unsafe FName SCSVariableName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComponentKey.__PropertyOffset_SCSVariableName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComponentKey.__PropertyOffset_SCSVariableName) = value;
			}
		}

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x06008764 RID: 34660 RVA: 0x000C1AA0 File Offset: 0x000BFCA0
		// (set) Token: 0x06008765 RID: 34661 RVA: 0x000C1AB4 File Offset: 0x000BFCB4
		public unsafe FGuid AssociatedGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComponentKey.__PropertyOffset_AssociatedGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComponentKey.__PropertyOffset_AssociatedGuid) = value;
			}
		}

		// Token: 0x06008766 RID: 34662 RVA: 0x000C1AC9 File Offset: 0x000BFCC9
		public FComponentKey()
		{
		}

		// Token: 0x06008767 RID: 34663 RVA: 0x000C1AD1 File Offset: 0x000BFCD1
		public FComponentKey(UClassStackOnlyPtr OwnerClass, FName SCSVariableName, FGuid AssociatedGuid)
		{
			this.OwnerClass = OwnerClass;
			this.SCSVariableName = SCSVariableName;
			this.AssociatedGuid = AssociatedGuid;
		}

		// Token: 0x06008768 RID: 34664 RVA: 0x000C1AEE File Offset: 0x000BFCEE
		protected override IntPtr GetUStructPtr()
		{
			return FComponentKey.StaticStruct();
		}

		// Token: 0x06008769 RID: 34665 RVA: 0x000C1AFA File Offset: 0x000BFCFA
		[NullableContext(2)]
		public FComponentKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600876A RID: 34666 RVA: 0x000C1B04 File Offset: 0x000BFD04
		public FComponentKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600876B RID: 34667 RVA: 0x000C1B0F File Offset: 0x000BFD0F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FComponentKey(Pointer, false, true);
		}

		// Token: 0x0600876C RID: 34668 RVA: 0x000C1B19 File Offset: 0x000BFD19
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FComponentKey(Pointer, MemoryOwner);
		}

		// Token: 0x04004064 RID: 16484
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentKey";

		// Token: 0x04004065 RID: 16485
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004066 RID: 16486
		internal static int __PropertyOffset_OwnerClass;

		// Token: 0x04004067 RID: 16487
		internal static int __PropertyOffset_SCSVariableName;

		// Token: 0x04004068 RID: 16488
		internal static int __PropertyOffset_AssociatedGuid;
	}
}
