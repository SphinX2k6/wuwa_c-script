using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B33 RID: 6963
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroLightActorBase")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AKuroLightActorBase : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A48B RID: 107659 RVA: 0x0026C8EB File Offset: 0x0026AAEB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroLightActorBase._ClassPtr;
		}

		// Token: 0x0601A48C RID: 107660 RVA: 0x0026C8F8 File Offset: 0x0026AAF8
		public AKuroLightActorBase() : this(BuiltinUtils.AllocNativeUObject(AKuroLightActorBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A48D RID: 107661 RVA: 0x0026C920 File Offset: 0x0026AB20
		[NullableContext(1)]
		public AKuroLightActorBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroLightActorBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069B1 RID: 27057
		// (get) Token: 0x0601A48E RID: 107662 RVA: 0x0026C953 File Offset: 0x0026AB53
		// (set) Token: 0x0601A48F RID: 107663 RVA: 0x0026C963 File Offset: 0x0026AB63
		public unsafe bool bEnableEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLightActorBase.__PropertyOffset_bEnableEditorTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLightActorBase.__PropertyOffset_bEnableEditorTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601A490 RID: 107664 RVA: 0x0026C974 File Offset: 0x0026AB74
		public virtual void Update(float DeltaSeconds)
		{
			AKuroLightActorBase.__Update_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x0601A491 RID: 107665 RVA: 0x0026C982 File Offset: 0x0026AB82
		public virtual void SetLightIntensityScale(float ScaleFactor)
		{
			AKuroLightActorBase.__SetLightIntensityScale_Internal(base.NativePtr, ScaleFactor);
		}

		// Token: 0x0601A492 RID: 107666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Update_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x0601A493 RID: 107667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightIntensityScale_Internal(IntPtr @this, float ScaleFactor);

		// Token: 0x0601A494 RID: 107668 RVA: 0x0026C990 File Offset: 0x0026AB90
		static AKuroLightActorBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroLightActorBase");
		}

		// Token: 0x0601A495 RID: 107669 RVA: 0x0026C99E File Offset: 0x0026AB9E
		protected AKuroLightActorBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E439 RID: 58425
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroLightActorBase";

		// Token: 0x0400E43A RID: 58426
		private static IntPtr _ClassPtr;

		// Token: 0x0400E43B RID: 58427
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E43C RID: 58428
		internal static int __PropertyOffset_bEnableEditorTick;

		// Token: 0x02003153 RID: 12627
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Update_FunctionParams
		{
			// Token: 0x04016F6A RID: 94058
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02003154 RID: 12628
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetLightIntensityScale_FunctionParams
		{
			// Token: 0x04016F6B RID: 94059
			[FieldOffset(0)]
			public float ScaleFactor;
		}
	}
}
