using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003EE RID: 1006
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroInputDelegateLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroInputDelegateLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060062F9 RID: 25337 RVA: 0x0008D5EA File Offset: 0x0008B7EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroInputDelegateLibrary._ClassPtr;
		}

		// Token: 0x060062FA RID: 25338 RVA: 0x0008D5F8 File Offset: 0x0008B7F8
		public UKuroInputDelegateLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroInputDelegateLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060062FB RID: 25339 RVA: 0x0008D620 File Offset: 0x0008B820
		[NullableContext(1)]
		public UKuroInputDelegateLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroInputDelegateLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060062FC RID: 25340 RVA: 0x0008D653 File Offset: 0x0008B853
		public static void RegisterTouchBinding(EInputEvent KeyEvent, AActor Actor, in FTouchBindingDelegate InDelegate)
		{
			TEnumAsByte<EInputEvent> keyEvent = KeyEvent;
			IntPtr actor = (Actor != null) ? Actor.NativePtr : IntPtr.Zero;
			FTouchBindingDelegate ftouchBindingDelegate = InDelegate;
			UKuroInputDelegateLibrary.__RegisterTouchBinding_Internal(keyEvent, actor, (ftouchBindingDelegate != null) ? ftouchBindingDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060062FD RID: 25341 RVA: 0x0008D67F File Offset: 0x0008B87F
		public static void RegisterKeyBinding(FInputChord Chord, EInputEvent KeyEvent, AActor Actor, in FKeyBindingDelegate InDelegate)
		{
			IntPtr nativePtr = (Chord ?? new FInputChord()).NativePtr;
			TEnumAsByte<EInputEvent> keyEvent = KeyEvent;
			IntPtr actor = (Actor != null) ? Actor.NativePtr : IntPtr.Zero;
			FKeyBindingDelegate fkeyBindingDelegate = InDelegate;
			UKuroInputDelegateLibrary.__RegisterKeyBinding_Internal(nativePtr, keyEvent, actor, (fkeyBindingDelegate != null) ? fkeyBindingDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060062FE RID: 25342 RVA: 0x0008D6BA File Offset: 0x0008B8BA
		public static void RegisterAxisBinding(FName AxisName, AActor Actor, in FAxisBindingDelegate InDelegate)
		{
			IntPtr actor = (Actor != null) ? Actor.NativePtr : IntPtr.Zero;
			FAxisBindingDelegate faxisBindingDelegate = InDelegate;
			UKuroInputDelegateLibrary.__RegisterAxisBinding_Internal(AxisName, actor, (faxisBindingDelegate != null) ? faxisBindingDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060062FF RID: 25343 RVA: 0x0008D6E1 File Offset: 0x0008B8E1
		public static void RegisterActionBinding(FName ActionName, EInputEvent KeyEvent, AActor Actor, in FActionBindingDelegate InDelegate)
		{
			TEnumAsByte<EInputEvent> keyEvent = KeyEvent;
			IntPtr actor = (Actor != null) ? Actor.NativePtr : IntPtr.Zero;
			FActionBindingDelegate factionBindingDelegate = InDelegate;
			UKuroInputDelegateLibrary.__RegisterActionBinding_Internal(ActionName, keyEvent, actor, (factionBindingDelegate != null) ? factionBindingDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06006300 RID: 25344
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void InitializeEnvironment();

		// Token: 0x06006301 RID: 25345
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyEnvironment();

		// Token: 0x06006302 RID: 25346 RVA: 0x0008D70E File Offset: 0x0008B90E
		public static void ClearTouchBinding(AActor Actor)
		{
			UKuroInputDelegateLibrary.__ClearTouchBinding_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006303 RID: 25347 RVA: 0x0008D725 File Offset: 0x0008B925
		public static void ClearKeyBinding(AActor Actor)
		{
			UKuroInputDelegateLibrary.__ClearKeyBinding_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006304 RID: 25348 RVA: 0x0008D73C File Offset: 0x0008B93C
		public static void ClearInputBinding(AActor Actor)
		{
			UKuroInputDelegateLibrary.__ClearInputBinding_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006305 RID: 25349 RVA: 0x0008D753 File Offset: 0x0008B953
		public static void ClearAxisBinding(AActor Actor)
		{
			UKuroInputDelegateLibrary.__ClearAxisBinding_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006306 RID: 25350 RVA: 0x0008D76A File Offset: 0x0008B96A
		public static void ClearActionBinding(AActor Actor)
		{
			UKuroInputDelegateLibrary.__ClearActionBinding_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006307 RID: 25351
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterTouchBinding_Internal(TEnumAsByte<EInputEvent> KeyEvent, IntPtr Actor, IntPtr InDelegate);

		// Token: 0x06006308 RID: 25352
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterKeyBinding_Internal(IntPtr Chord, TEnumAsByte<EInputEvent> KeyEvent, IntPtr Actor, IntPtr InDelegate);

		// Token: 0x06006309 RID: 25353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterAxisBinding_Internal(FName AxisName, IntPtr Actor, IntPtr InDelegate);

		// Token: 0x0600630A RID: 25354
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterActionBinding_Internal(FName ActionName, TEnumAsByte<EInputEvent> KeyEvent, IntPtr Actor, IntPtr InDelegate);

		// Token: 0x0600630B RID: 25355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearTouchBinding_Internal(IntPtr Actor);

		// Token: 0x0600630C RID: 25356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearKeyBinding_Internal(IntPtr Actor);

		// Token: 0x0600630D RID: 25357
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearInputBinding_Internal(IntPtr Actor);

		// Token: 0x0600630E RID: 25358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAxisBinding_Internal(IntPtr Actor);

		// Token: 0x0600630F RID: 25359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearActionBinding_Internal(IntPtr Actor);

		// Token: 0x06006310 RID: 25360 RVA: 0x0008D781 File Offset: 0x0008B981
		static UKuroInputDelegateLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroInputDelegateLibrary");
		}

		// Token: 0x06006311 RID: 25361 RVA: 0x0008D78F File Offset: 0x0008B98F
		protected UKuroInputDelegateLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040029D3 RID: 10707
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroInputDelegateLibrary";

		// Token: 0x040029D4 RID: 10708
		private static IntPtr _ClassPtr;

		// Token: 0x040029D5 RID: 10709
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
