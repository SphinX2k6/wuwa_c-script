using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200122D RID: 4653
	[UnrealObjectPath("/Script/Engine.ViewportStatsSubsystem")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UViewportStatsSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060111D3 RID: 70099 RVA: 0x00191D0F File Offset: 0x0018FF0F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UViewportStatsSubsystem._ClassPtr;
		}

		// Token: 0x060111D4 RID: 70100 RVA: 0x00191D1C File Offset: 0x0018FF1C
		public UViewportStatsSubsystem() : this(BuiltinUtils.AllocNativeUObject(UViewportStatsSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060111D5 RID: 70101 RVA: 0x00191D44 File Offset: 0x0018FF44
		[NullableContext(1)]
		public UViewportStatsSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UViewportStatsSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060111D6 RID: 70102 RVA: 0x00191D77 File Offset: 0x0018FF77
		public void RemoveDisplayDelegate(int IndexToRemove)
		{
			UViewportStatsSubsystem.__RemoveDisplayDelegate_Internal(base.NativePtr, IndexToRemove);
		}

		// Token: 0x060111D7 RID: 70103 RVA: 0x00191D88 File Offset: 0x0018FF88
		[NullableContext(1)]
		public void AddTimedDisplay(FText Text, FLinearColor? Color = null, float Duration = 0f)
		{
			UViewportStatsSubsystem.__AddTimedDisplay_Internal(base.NativePtr, (Text != null) ? Text.NativePtr : IntPtr.Zero, Color ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, Duration);
		}

		// Token: 0x060111D8 RID: 70104 RVA: 0x00191DFD File Offset: 0x0018FFFD
		[NullableContext(2)]
		public int AddDisplayDelegate(in FViewportDisplayCallback Delegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FViewportDisplayCallback fviewportDisplayCallback = Delegate;
			return UViewportStatsSubsystem.__AddDisplayDelegate_Internal(nativePtr, (fviewportDisplayCallback != null) ? fviewportDisplayCallback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060111D9 RID: 70105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveDisplayDelegate_Internal(IntPtr @this, int IndexToRemove);

		// Token: 0x060111DA RID: 70106
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTimedDisplay_Internal(IntPtr @this, IntPtr Text, FLinearColor Color, float Duration);

		// Token: 0x060111DB RID: 70107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddDisplayDelegate_Internal(IntPtr @this, IntPtr Delegate);

		// Token: 0x060111DC RID: 70108 RVA: 0x00191E19 File Offset: 0x00190019
		static UViewportStatsSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ViewportStatsSubsystem");
		}

		// Token: 0x060111DD RID: 70109 RVA: 0x00191E27 File Offset: 0x00190027
		protected UViewportStatsSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400928F RID: 37519
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ViewportStatsSubsystem";

		// Token: 0x04009290 RID: 37520
		private static IntPtr _ClassPtr;

		// Token: 0x04009291 RID: 37521
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
