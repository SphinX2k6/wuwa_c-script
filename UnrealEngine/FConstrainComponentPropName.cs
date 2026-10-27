using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200096D RID: 2413
	[UnrealObjectPath("/Script/Engine.ConstrainComponentPropName")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FConstrainComponentPropName : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008837 RID: 34871 RVA: 0x000C32B2 File Offset: 0x000C14B2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConstrainComponentPropName._ScriptStructPtr != 0) ? FConstrainComponentPropName._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ConstrainComponentPropName", ref FConstrainComponentPropName._ScriptStructPtr);
		}

		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x06008838 RID: 34872 RVA: 0x000C32D6 File Offset: 0x000C14D6
		// (set) Token: 0x06008839 RID: 34873 RVA: 0x000C32EA File Offset: 0x000C14EA
		public unsafe FName ComponentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstrainComponentPropName.__PropertyOffset_ComponentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstrainComponentPropName.__PropertyOffset_ComponentName) = value;
			}
		}

		// Token: 0x0600883A RID: 34874 RVA: 0x000C32FF File Offset: 0x000C14FF
		public FConstrainComponentPropName()
		{
		}

		// Token: 0x0600883B RID: 34875 RVA: 0x000C3307 File Offset: 0x000C1507
		public FConstrainComponentPropName(FName ComponentName)
		{
			this.ComponentName = ComponentName;
		}

		// Token: 0x0600883C RID: 34876 RVA: 0x000C3316 File Offset: 0x000C1516
		protected override IntPtr GetUStructPtr()
		{
			return FConstrainComponentPropName.StaticStruct();
		}

		// Token: 0x0600883D RID: 34877 RVA: 0x000C3322 File Offset: 0x000C1522
		[NullableContext(2)]
		public FConstrainComponentPropName(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600883E RID: 34878 RVA: 0x000C332C File Offset: 0x000C152C
		public FConstrainComponentPropName(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600883F RID: 34879 RVA: 0x000C3337 File Offset: 0x000C1537
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConstrainComponentPropName(Pointer, false, true);
		}

		// Token: 0x06008840 RID: 34880 RVA: 0x000C3341 File Offset: 0x000C1541
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConstrainComponentPropName(Pointer, MemoryOwner);
		}

		// Token: 0x040040C3 RID: 16579
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ConstrainComponentPropName";

		// Token: 0x040040C4 RID: 16580
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040040C5 RID: 16581
		internal static int __PropertyOffset_ComponentName;
	}
}
