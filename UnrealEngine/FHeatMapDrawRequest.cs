using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A9E RID: 6814
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.HeatMapDrawRequest")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FHeatMapDrawRequest : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601936C RID: 103276 RVA: 0x00254C93 File Offset: 0x00252E93
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHeatMapDrawRequest._ScriptStructPtr != 0) ? FHeatMapDrawRequest._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.HeatMapDrawRequest", ref FHeatMapDrawRequest._ScriptStructPtr);
		}

		// Token: 0x17006476 RID: 25718
		// (get) Token: 0x0601936D RID: 103277 RVA: 0x00254CB7 File Offset: 0x00252EB7
		// (set) Token: 0x0601936E RID: 103278 RVA: 0x00254CCB File Offset: 0x00252ECB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UTextureRenderTarget2D> TargetRT
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FHeatMapDrawRequest.__PropertyOffset_TargetRT);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FHeatMapDrawRequest.__PropertyOffset_TargetRT) = value;
			}
		}

		// Token: 0x17006477 RID: 25719
		// (get) Token: 0x0601936F RID: 103279 RVA: 0x00254CE0 File Offset: 0x00252EE0
		// (set) Token: 0x06019370 RID: 103280 RVA: 0x00254CF0 File Offset: 0x00252EF0
		public unsafe bool bPersistenceRequest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHeatMapDrawRequest.__PropertyOffset_bPersistenceRequest) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHeatMapDrawRequest.__PropertyOffset_bPersistenceRequest) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006478 RID: 25720
		// (get) Token: 0x06019371 RID: 103281 RVA: 0x00254D01 File Offset: 0x00252F01
		// (set) Token: 0x06019372 RID: 103282 RVA: 0x00254D11 File Offset: 0x00252F11
		public unsafe float QueryRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHeatMapDrawRequest.__PropertyOffset_QueryRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHeatMapDrawRequest.__PropertyOffset_QueryRadius) = value;
			}
		}

		// Token: 0x17006479 RID: 25721
		// (get) Token: 0x06019373 RID: 103283 RVA: 0x00254D22 File Offset: 0x00252F22
		// (set) Token: 0x06019374 RID: 103284 RVA: 0x00254D36 File Offset: 0x00252F36
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AActor> TargetActorClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FHeatMapDrawRequest.__PropertyOffset_TargetActorClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FHeatMapDrawRequest.__PropertyOffset_TargetActorClass) = value;
			}
		}

		// Token: 0x1700647A RID: 25722
		// (get) Token: 0x06019375 RID: 103285 RVA: 0x00254D4B File Offset: 0x00252F4B
		// (set) Token: 0x06019376 RID: 103286 RVA: 0x00254D5F File Offset: 0x00252F5F
		public unsafe FName DataLayerLabel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHeatMapDrawRequest.__PropertyOffset_DataLayerLabel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHeatMapDrawRequest.__PropertyOffset_DataLayerLabel) = value;
			}
		}

		// Token: 0x06019377 RID: 103287 RVA: 0x00254D74 File Offset: 0x00252F74
		public FHeatMapDrawRequest()
		{
		}

		// Token: 0x06019378 RID: 103288 RVA: 0x00254D7C File Offset: 0x00252F7C
		public FHeatMapDrawRequest([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UTextureRenderTarget2D> TargetRT, bool bPersistenceRequest, float QueryRadius, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> TargetActorClass, FName DataLayerLabel)
		{
			this.TargetRT = TargetRT;
			this.bPersistenceRequest = bPersistenceRequest;
			this.QueryRadius = QueryRadius;
			this.TargetActorClass = TargetActorClass;
			this.DataLayerLabel = DataLayerLabel;
		}

		// Token: 0x06019379 RID: 103289 RVA: 0x00254DA9 File Offset: 0x00252FA9
		protected override IntPtr GetUStructPtr()
		{
			return FHeatMapDrawRequest.StaticStruct();
		}

		// Token: 0x0601937A RID: 103290 RVA: 0x00254DB5 File Offset: 0x00252FB5
		[NullableContext(2)]
		public FHeatMapDrawRequest(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601937B RID: 103291 RVA: 0x00254DBF File Offset: 0x00252FBF
		public FHeatMapDrawRequest(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601937C RID: 103292 RVA: 0x00254DCA File Offset: 0x00252FCA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHeatMapDrawRequest(Pointer, false, true);
		}

		// Token: 0x0601937D RID: 103293 RVA: 0x00254DD4 File Offset: 0x00252FD4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHeatMapDrawRequest(Pointer, MemoryOwner);
		}

		// Token: 0x0400DC13 RID: 56339
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.HeatMapDrawRequest";

		// Token: 0x0400DC14 RID: 56340
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DC15 RID: 56341
		internal static int __PropertyOffset_TargetRT;

		// Token: 0x0400DC16 RID: 56342
		internal static int __PropertyOffset_bPersistenceRequest;

		// Token: 0x0400DC17 RID: 56343
		internal static int __PropertyOffset_QueryRadius;

		// Token: 0x0400DC18 RID: 56344
		internal static int __PropertyOffset_TargetActorClass;

		// Token: 0x0400DC19 RID: 56345
		internal static int __PropertyOffset_DataLayerLabel;
	}
}
