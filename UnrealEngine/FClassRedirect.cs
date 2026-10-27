using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000933 RID: 2355
	[UnrealObjectPath("/Script/Engine.ClassRedirect")]
	[UnrealStructLayout(88, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FClassRedirect : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008511 RID: 34065 RVA: 0x000BDC8F File Offset: 0x000BBE8F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClassRedirect._ScriptStructPtr != 0) ? FClassRedirect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ClassRedirect", ref FClassRedirect._ScriptStructPtr);
		}

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x06008512 RID: 34066 RVA: 0x000BDCB3 File Offset: 0x000BBEB3
		// (set) Token: 0x06008513 RID: 34067 RVA: 0x000BDCC7 File Offset: 0x000BBEC7
		public unsafe FName ObjectName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClassRedirect.__PropertyOffset_ObjectName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClassRedirect.__PropertyOffset_ObjectName) = value;
			}
		}

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x06008514 RID: 34068 RVA: 0x000BDCDC File Offset: 0x000BBEDC
		// (set) Token: 0x06008515 RID: 34069 RVA: 0x000BDCF0 File Offset: 0x000BBEF0
		public unsafe FName OldClassName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClassRedirect.__PropertyOffset_OldClassName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClassRedirect.__PropertyOffset_OldClassName) = value;
			}
		}

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x06008516 RID: 34070 RVA: 0x000BDD05 File Offset: 0x000BBF05
		// (set) Token: 0x06008517 RID: 34071 RVA: 0x000BDD19 File Offset: 0x000BBF19
		public unsafe FName NewClassName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClassRedirect.__PropertyOffset_NewClassName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClassRedirect.__PropertyOffset_NewClassName) = value;
			}
		}

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x06008518 RID: 34072 RVA: 0x000BDD2E File Offset: 0x000BBF2E
		// (set) Token: 0x06008519 RID: 34073 RVA: 0x000BDD42 File Offset: 0x000BBF42
		public unsafe FName OldSubobjName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClassRedirect.__PropertyOffset_OldSubobjName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClassRedirect.__PropertyOffset_OldSubobjName) = value;
			}
		}

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x0600851A RID: 34074 RVA: 0x000BDD57 File Offset: 0x000BBF57
		// (set) Token: 0x0600851B RID: 34075 RVA: 0x000BDD6B File Offset: 0x000BBF6B
		public unsafe FName NewSubobjName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClassRedirect.__PropertyOffset_NewSubobjName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClassRedirect.__PropertyOffset_NewSubobjName) = value;
			}
		}

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x0600851C RID: 34076 RVA: 0x000BDD80 File Offset: 0x000BBF80
		// (set) Token: 0x0600851D RID: 34077 RVA: 0x000BDD94 File Offset: 0x000BBF94
		public unsafe FName NewClassClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClassRedirect.__PropertyOffset_NewClassClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClassRedirect.__PropertyOffset_NewClassClass) = value;
			}
		}

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x0600851E RID: 34078 RVA: 0x000BDDA9 File Offset: 0x000BBFA9
		// (set) Token: 0x0600851F RID: 34079 RVA: 0x000BDDBD File Offset: 0x000BBFBD
		public unsafe FName NewClassPackage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClassRedirect.__PropertyOffset_NewClassPackage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClassRedirect.__PropertyOffset_NewClassPackage) = value;
			}
		}

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x06008520 RID: 34080 RVA: 0x000BDDD2 File Offset: 0x000BBFD2
		// (set) Token: 0x06008521 RID: 34081 RVA: 0x000BDDE2 File Offset: 0x000BBFE2
		public unsafe bool InstanceOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClassRedirect.__PropertyOffset_InstanceOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClassRedirect.__PropertyOffset_InstanceOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x06008522 RID: 34082 RVA: 0x000BDDF3 File Offset: 0x000BBFF3
		public FClassRedirect()
		{
		}

		// Token: 0x06008523 RID: 34083 RVA: 0x000BDDFC File Offset: 0x000BBFFC
		public FClassRedirect(FName ObjectName, FName OldClassName, FName NewClassName, FName OldSubobjName, FName NewSubobjName, FName NewClassClass, FName NewClassPackage, bool InstanceOnly)
		{
			this.ObjectName = ObjectName;
			this.OldClassName = OldClassName;
			this.NewClassName = NewClassName;
			this.OldSubobjName = OldSubobjName;
			this.NewSubobjName = NewSubobjName;
			this.NewClassClass = NewClassClass;
			this.NewClassPackage = NewClassPackage;
			this.InstanceOnly = InstanceOnly;
		}

		// Token: 0x06008524 RID: 34084 RVA: 0x000BDE4C File Offset: 0x000BC04C
		protected override IntPtr GetUStructPtr()
		{
			return FClassRedirect.StaticStruct();
		}

		// Token: 0x06008525 RID: 34085 RVA: 0x000BDE58 File Offset: 0x000BC058
		[NullableContext(2)]
		public FClassRedirect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008526 RID: 34086 RVA: 0x000BDE62 File Offset: 0x000BC062
		public FClassRedirect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008527 RID: 34087 RVA: 0x000BDE6D File Offset: 0x000BC06D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClassRedirect(Pointer, false, true);
		}

		// Token: 0x06008528 RID: 34088 RVA: 0x000BDE77 File Offset: 0x000BC077
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClassRedirect(Pointer, MemoryOwner);
		}

		// Token: 0x04003F53 RID: 16211
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ClassRedirect";

		// Token: 0x04003F54 RID: 16212
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003F55 RID: 16213
		internal static int __PropertyOffset_ObjectName;

		// Token: 0x04003F56 RID: 16214
		internal static int __PropertyOffset_OldClassName;

		// Token: 0x04003F57 RID: 16215
		internal static int __PropertyOffset_NewClassName;

		// Token: 0x04003F58 RID: 16216
		internal static int __PropertyOffset_OldSubobjName;

		// Token: 0x04003F59 RID: 16217
		internal static int __PropertyOffset_NewSubobjName;

		// Token: 0x04003F5A RID: 16218
		internal static int __PropertyOffset_NewClassClass;

		// Token: 0x04003F5B RID: 16219
		internal static int __PropertyOffset_NewClassPackage;

		// Token: 0x04003F5C RID: 16220
		internal static int __PropertyOffset_InstanceOnly;
	}
}
