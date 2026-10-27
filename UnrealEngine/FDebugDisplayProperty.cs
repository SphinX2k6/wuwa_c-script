using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009A5 RID: 2469
	[UnrealObjectPath("/Script/Engine.DebugDisplayProperty")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FDebugDisplayProperty : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008B74 RID: 35700 RVA: 0x000C7CF6 File Offset: 0x000C5EF6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDebugDisplayProperty._ScriptStructPtr != 0) ? FDebugDisplayProperty._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DebugDisplayProperty", ref FDebugDisplayProperty._ScriptStructPtr);
		}

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x06008B75 RID: 35701 RVA: 0x000C7D1A File Offset: 0x000C5F1A
		// (set) Token: 0x06008B76 RID: 35702 RVA: 0x000C7D2E File Offset: 0x000C5F2E
		[Nullable(2)]
		public unsafe UObject Obj
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FDebugDisplayProperty.__PropertyOffset_Obj);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FDebugDisplayProperty.__PropertyOffset_Obj, value);
			}
		}

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x06008B77 RID: 35703 RVA: 0x000C7D43 File Offset: 0x000C5F43
		// (set) Token: 0x06008B78 RID: 35704 RVA: 0x000C7D57 File Offset: 0x000C5F57
		public unsafe UClassStackOnlyPtr WithinClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDebugDisplayProperty.__PropertyOffset_WithinClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDebugDisplayProperty.__PropertyOffset_WithinClass) = value;
			}
		}

		// Token: 0x06008B79 RID: 35705 RVA: 0x000C7D6C File Offset: 0x000C5F6C
		public FDebugDisplayProperty()
		{
		}

		// Token: 0x06008B7A RID: 35706 RVA: 0x000C7D74 File Offset: 0x000C5F74
		[NullableContext(1)]
		public FDebugDisplayProperty(UObject Obj, UClassStackOnlyPtr WithinClass)
		{
			this.Obj = Obj;
			this.WithinClass = WithinClass;
		}

		// Token: 0x06008B7B RID: 35707 RVA: 0x000C7D8A File Offset: 0x000C5F8A
		protected override IntPtr GetUStructPtr()
		{
			return FDebugDisplayProperty.StaticStruct();
		}

		// Token: 0x06008B7C RID: 35708 RVA: 0x000C7D96 File Offset: 0x000C5F96
		[NullableContext(2)]
		public FDebugDisplayProperty(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008B7D RID: 35709 RVA: 0x000C7DA0 File Offset: 0x000C5FA0
		public FDebugDisplayProperty(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008B7E RID: 35710 RVA: 0x000C7DAB File Offset: 0x000C5FAB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDebugDisplayProperty(Pointer, false, true);
		}

		// Token: 0x06008B7F RID: 35711 RVA: 0x000C7DB5 File Offset: 0x000C5FB5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDebugDisplayProperty(Pointer, MemoryOwner);
		}

		// Token: 0x0400423F RID: 16959
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.DebugDisplayProperty";

		// Token: 0x04004240 RID: 16960
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004241 RID: 16961
		internal static int __PropertyOffset_Obj;

		// Token: 0x04004242 RID: 16962
		internal static int __PropertyOffset_WithinClass;
	}
}
