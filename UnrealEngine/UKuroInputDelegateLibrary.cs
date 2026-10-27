using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018DC RID: 6364
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroInputDelegateLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroInputDelegateLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601792C RID: 96556 RVA: 0x0022816E File Offset: 0x0022636E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroInputDelegateLibrary._ClassPtr;
		}

		// Token: 0x0601792D RID: 96557 RVA: 0x0022817C File Offset: 0x0022637C
		public UKuroInputDelegateLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroInputDelegateLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601792E RID: 96558 RVA: 0x002281A4 File Offset: 0x002263A4
		[NullableContext(1)]
		public UKuroInputDelegateLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroInputDelegateLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601792F RID: 96559 RVA: 0x002281D7 File Offset: 0x002263D7
		public static void RegisterTouchBinding(EInputEvent KeyEvent, AActor Actor, in FTouchBindingDelegate InDelegate)
		{
			TEnumAsByte<EInputEvent> keyEvent = KeyEvent;
			IntPtr actor = (Actor != null) ? Actor.NativePtr : IntPtr.Zero;
			FTouchBindingDelegate ftouchBindingDelegate = InDelegate;
			UKuroInputDelegateLibrary.__RegisterTouchBinding_Internal(keyEvent, actor, (ftouchBindingDelegate != null) ? ftouchBindingDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06017930 RID: 96560 RVA: 0x00228203 File Offset: 0x00226403
		public static void RegisterKeyBinding(FInputChord Chord, EInputEvent KeyEvent, AActor Actor, in FKeyBindingDelegate InDelegate)
		{
			IntPtr nativePtr = (Chord ?? new FInputChord()).NativePtr;
			TEnumAsByte<EInputEvent> keyEvent = KeyEvent;
			IntPtr actor = (Actor != null) ? Actor.NativePtr : IntPtr.Zero;
			FKeyBindingDelegate fkeyBindingDelegate = InDelegate;
			UKuroInputDelegateLibrary.__RegisterKeyBinding_Internal(nativePtr, keyEvent, actor, (fkeyBindingDelegate != null) ? fkeyBindingDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06017931 RID: 96561 RVA: 0x0022823E File Offset: 0x0022643E
		public static void RegisterAxisBinding(FName AxisName, AActor Actor, in FAxisBindingDelegate InDelegate)
		{
			IntPtr actor = (Actor != null) ? Actor.NativePtr : IntPtr.Zero;
			FAxisBindingDelegate faxisBindingDelegate = InDelegate;
			UKuroInputDelegateLibrary.__RegisterAxisBinding_Internal(AxisName, actor, (faxisBindingDelegate != null) ? faxisBindingDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06017932 RID: 96562 RVA: 0x00228265 File Offset: 0x00226465
		public static void RegisterActionBinding(FName ActionName, EInputEvent KeyEvent, AActor Actor, in FActionBindingDelegate InDelegate)
		{
			TEnumAsByte<EInputEvent> keyEvent = KeyEvent;
			IntPtr actor = (Actor != null) ? Actor.NativePtr : IntPtr.Zero;
			FActionBindingDelegate factionBindingDelegate = InDelegate;
			UKuroInputDelegateLibrary.__RegisterActionBinding_Internal(ActionName, keyEvent, actor, (factionBindingDelegate != null) ? factionBindingDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06017933 RID: 96563
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void InitializeEnvironment();

		// Token: 0x06017934 RID: 96564
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyEnvironment();

		// Token: 0x06017935 RID: 96565 RVA: 0x00228292 File Offset: 0x00226492
		public static void ClearTouchBinding(AActor Actor)
		{
			UKuroInputDelegateLibrary.__ClearTouchBinding_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017936 RID: 96566 RVA: 0x002282A9 File Offset: 0x002264A9
		public static void ClearKeyBinding(AActor Actor)
		{
			UKuroInputDelegateLibrary.__ClearKeyBinding_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017937 RID: 96567 RVA: 0x002282C0 File Offset: 0x002264C0
		public static void ClearInputBinding(AActor Actor)
		{
			UKuroInputDelegateLibrary.__ClearInputBinding_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017938 RID: 96568 RVA: 0x002282D7 File Offset: 0x002264D7
		public static void ClearAxisBinding(AActor Actor)
		{
			UKuroInputDelegateLibrary.__ClearAxisBinding_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017939 RID: 96569 RVA: 0x002282EE File Offset: 0x002264EE
		public static void ClearActionBinding(AActor Actor)
		{
			UKuroInputDelegateLibrary.__ClearActionBinding_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601793A RID: 96570
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterTouchBinding_Internal(TEnumAsByte<EInputEvent> KeyEvent, IntPtr Actor, IntPtr InDelegate);

		// Token: 0x0601793B RID: 96571
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterKeyBinding_Internal(IntPtr Chord, TEnumAsByte<EInputEvent> KeyEvent, IntPtr Actor, IntPtr InDelegate);

		// Token: 0x0601793C RID: 96572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterAxisBinding_Internal(FName AxisName, IntPtr Actor, IntPtr InDelegate);

		// Token: 0x0601793D RID: 96573
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterActionBinding_Internal(FName ActionName, TEnumAsByte<EInputEvent> KeyEvent, IntPtr Actor, IntPtr InDelegate);

		// Token: 0x0601793E RID: 96574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearTouchBinding_Internal(IntPtr Actor);

		// Token: 0x0601793F RID: 96575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearKeyBinding_Internal(IntPtr Actor);

		// Token: 0x06017940 RID: 96576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearInputBinding_Internal(IntPtr Actor);

		// Token: 0x06017941 RID: 96577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAxisBinding_Internal(IntPtr Actor);

		// Token: 0x06017942 RID: 96578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearActionBinding_Internal(IntPtr Actor);

		// Token: 0x06017943 RID: 96579 RVA: 0x00228305 File Offset: 0x00226505
		static UKuroInputDelegateLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroInputDelegateLibrary");
		}

		// Token: 0x06017944 RID: 96580 RVA: 0x00228313 File Offset: 0x00226513
		protected UKuroInputDelegateLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CCBB RID: 52411
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroInputDelegateLibrary";

		// Token: 0x0400CCBC RID: 52412
		private static IntPtr _ClassPtr;

		// Token: 0x0400CCBD RID: 52413
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
