using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FC7 RID: 8135
	[UnrealObjectPath("/Script/LGUI.ActorBindings")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FActorBindings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EDD3 RID: 126419 RVA: 0x002DDEC1 File Offset: 0x002DC0C1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorBindings._ScriptStructPtr != 0) ? FActorBindings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.ActorBindings", ref FActorBindings._ScriptStructPtr);
		}

		// Token: 0x0601EDD4 RID: 126420 RVA: 0x002DDEE5 File Offset: 0x002DC0E5
		public FActorBindings()
		{
		}

		// Token: 0x0601EDD5 RID: 126421 RVA: 0x002DDEED File Offset: 0x002DC0ED
		protected override IntPtr GetUStructPtr()
		{
			return FActorBindings.StaticStruct();
		}

		// Token: 0x0601EDD6 RID: 126422 RVA: 0x002DDEF9 File Offset: 0x002DC0F9
		[NullableContext(2)]
		public FActorBindings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EDD7 RID: 126423 RVA: 0x002DDF03 File Offset: 0x002DC103
		public FActorBindings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EDD8 RID: 126424 RVA: 0x002DDF0E File Offset: 0x002DC10E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorBindings(Pointer, false, true);
		}

		// Token: 0x0601EDD9 RID: 126425 RVA: 0x002DDF18 File Offset: 0x002DC118
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorBindings(Pointer, MemoryOwner);
		}

		// Token: 0x04010ACD RID: 68301
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.ActorBindings";

		// Token: 0x04010ACE RID: 68302
		private static IntPtr _ScriptStructPtr;
	}
}
