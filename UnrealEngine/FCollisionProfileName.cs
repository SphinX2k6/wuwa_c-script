using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001A7 RID: 423
	[UnrealObjectPath("/Script/Engine.CollisionProfileName")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FCollisionProfileName : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001F80 RID: 8064 RVA: 0x0002D93E File Offset: 0x0002BB3E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCollisionProfileName._ScriptStructPtr != 0) ? FCollisionProfileName._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CollisionProfileName", ref FCollisionProfileName._ScriptStructPtr);
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x0002D962 File Offset: 0x0002BB62
		// (set) Token: 0x06001F82 RID: 8066 RVA: 0x0002D976 File Offset: 0x0002BB76
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCollisionProfileName.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCollisionProfileName.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x0002D98B File Offset: 0x0002BB8B
		public FCollisionProfileName()
		{
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x0002D993 File Offset: 0x0002BB93
		protected override IntPtr GetUStructPtr()
		{
			return FCollisionProfileName.StaticStruct();
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x0002D99F File Offset: 0x0002BB9F
		[NullableContext(2)]
		public FCollisionProfileName(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x0002D9A9 File Offset: 0x0002BBA9
		public FCollisionProfileName(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x0002D9B4 File Offset: 0x0002BBB4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCollisionProfileName(Pointer, false, true);
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x0002D9BE File Offset: 0x0002BBBE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCollisionProfileName(Pointer, MemoryOwner);
		}

		// Token: 0x04000A6E RID: 2670
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CollisionProfileName";

		// Token: 0x04000A6F RID: 2671
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000A70 RID: 2672
		internal static int __PropertyOffset_Name;
	}
}
