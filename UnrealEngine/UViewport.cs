using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029F2 RID: 10738
	[UnrealObjectPath("/Script/UMG.Viewport")]
	[UnrealStructLayout(776, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 776)]
	public class UViewport : UContentWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027D30 RID: 163120 RVA: 0x003CAE88 File Offset: 0x003C9088
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UViewport._ClassPtr;
		}

		// Token: 0x06027D31 RID: 163121 RVA: 0x003CAE94 File Offset: 0x003C9094
		public UViewport() : this(BuiltinUtils.AllocNativeUObject(UViewport.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027D32 RID: 163122 RVA: 0x003CAEBC File Offset: 0x003C90BC
		[NullableContext(1)]
		public UViewport(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UViewport.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009862 RID: 39010
		// (get) Token: 0x06027D33 RID: 163123 RVA: 0x003CAEEF File Offset: 0x003C90EF
		// (set) Token: 0x06027D34 RID: 163124 RVA: 0x003CAF03 File Offset: 0x003C9103
		public unsafe FLinearColor BackgroundColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UViewport.__PropertyOffset_BackgroundColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UViewport.__PropertyOffset_BackgroundColor) = value;
			}
		}

		// Token: 0x06027D35 RID: 163125 RVA: 0x003CAF18 File Offset: 0x003C9118
		[NullableContext(2)]
		public AActor Spawn([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> ActorClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UViewport.__Spawn_Internal(base.NativePtr, ActorClass._NativePtr));
		}

		// Token: 0x06027D36 RID: 163126 RVA: 0x003CAF30 File Offset: 0x003C9130
		public void SetViewRotation(FRotator Rotation)
		{
			UViewport.__SetViewRotation_Internal(base.NativePtr, Rotation);
		}

		// Token: 0x06027D37 RID: 163127 RVA: 0x003CAF3E File Offset: 0x003C913E
		public void SetViewLocation(FVector Location)
		{
			UViewport.__SetViewLocation_Internal(base.NativePtr, Location);
		}

		// Token: 0x06027D38 RID: 163128 RVA: 0x003CAF4C File Offset: 0x003C914C
		public FRotator GetViewRotation()
		{
			return UViewport.__GetViewRotation_Internal(base.NativePtr);
		}

		// Token: 0x06027D39 RID: 163129 RVA: 0x003CAF59 File Offset: 0x003C9159
		[NullableContext(2)]
		public UWorld GetViewportWorld()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorld>(UViewport.__GetViewportWorld_Internal(base.NativePtr));
		}

		// Token: 0x06027D3A RID: 163130 RVA: 0x003CAF6B File Offset: 0x003C916B
		public FVector GetViewLocation()
		{
			return UViewport.__GetViewLocation_Internal(base.NativePtr);
		}

		// Token: 0x06027D3B RID: 163131
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Spawn_Internal(IntPtr @this, IntPtr ActorClass);

		// Token: 0x06027D3C RID: 163132
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetViewRotation_Internal(IntPtr @this, FRotator Rotation);

		// Token: 0x06027D3D RID: 163133
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetViewLocation_Internal(IntPtr @this, FVector Location);

		// Token: 0x06027D3E RID: 163134
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetViewRotation_Internal(IntPtr @this);

		// Token: 0x06027D3F RID: 163135
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetViewportWorld_Internal(IntPtr @this);

		// Token: 0x06027D40 RID: 163136
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetViewLocation_Internal(IntPtr @this);

		// Token: 0x06027D41 RID: 163137 RVA: 0x003CAF78 File Offset: 0x003C9178
		static UViewport()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.Viewport");
		}

		// Token: 0x06027D42 RID: 163138 RVA: 0x003CAF86 File Offset: 0x003C9186
		protected UViewport(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C70 RID: 89200
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.Viewport";

		// Token: 0x04015C71 RID: 89201
		private static IntPtr _ClassPtr;

		// Token: 0x04015C72 RID: 89202
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015C73 RID: 89203
		internal static int __PropertyOffset_BackgroundColor;
	}
}
