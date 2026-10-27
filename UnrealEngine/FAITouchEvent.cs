using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200011A RID: 282
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AITouchEvent")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAITouchEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060014B0 RID: 5296 RVA: 0x0001E7CE File Offset: 0x0001C9CE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAITouchEvent._ScriptStructPtr != 0) ? FAITouchEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.AITouchEvent", ref FAITouchEvent._ScriptStructPtr);
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x0001E7F2 File Offset: 0x0001C9F2
		// (set) Token: 0x060014B2 RID: 5298 RVA: 0x0001E806 File Offset: 0x0001CA06
		public unsafe AActor TouchReceiver
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FAITouchEvent.__PropertyOffset_TouchReceiver);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAITouchEvent.__PropertyOffset_TouchReceiver, value);
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x0001E81B File Offset: 0x0001CA1B
		// (set) Token: 0x060014B4 RID: 5300 RVA: 0x0001E82F File Offset: 0x0001CA2F
		public unsafe AActor OtherActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FAITouchEvent.__PropertyOffset_OtherActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAITouchEvent.__PropertyOffset_OtherActor, value);
			}
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0001E844 File Offset: 0x0001CA44
		public FAITouchEvent()
		{
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0001E84C File Offset: 0x0001CA4C
		[NullableContext(1)]
		public FAITouchEvent(AActor TouchReceiver, AActor OtherActor)
		{
			this.TouchReceiver = TouchReceiver;
			this.OtherActor = OtherActor;
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0001E862 File Offset: 0x0001CA62
		protected override IntPtr GetUStructPtr()
		{
			return FAITouchEvent.StaticStruct();
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0001E86E File Offset: 0x0001CA6E
		public FAITouchEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0001E878 File Offset: 0x0001CA78
		public FAITouchEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0001E883 File Offset: 0x0001CA83
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAITouchEvent(Pointer, false, true);
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0001E88D File Offset: 0x0001CA8D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAITouchEvent(Pointer, MemoryOwner);
		}

		// Token: 0x0400043B RID: 1083
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.AITouchEvent";

		// Token: 0x0400043C RID: 1084
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400043D RID: 1085
		internal static int __PropertyOffset_TouchReceiver;

		// Token: 0x0400043E RID: 1086
		internal static int __PropertyOffset_OtherActor;
	}
}
