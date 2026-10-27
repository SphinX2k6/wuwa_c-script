using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B17 RID: 6935
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGPUParticleMeshInfo")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKuroGPUParticleMeshInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A17F RID: 106879 RVA: 0x002682B6 File Offset: 0x002664B6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGPUParticleMeshInfo._ScriptStructPtr != 0) ? FKuroGPUParticleMeshInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroGPUParticleMeshInfo", ref FKuroGPUParticleMeshInfo._ScriptStructPtr);
		}

		// Token: 0x170068C3 RID: 26819
		// (get) Token: 0x0601A180 RID: 106880 RVA: 0x002682DA File Offset: 0x002664DA
		// (set) Token: 0x0601A181 RID: 106881 RVA: 0x002682EA File Offset: 0x002664EA
		public unsafe int StartFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGPUParticleMeshInfo.__PropertyOffset_StartFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGPUParticleMeshInfo.__PropertyOffset_StartFrame) = value;
			}
		}

		// Token: 0x170068C4 RID: 26820
		// (get) Token: 0x0601A182 RID: 106882 RVA: 0x002682FB File Offset: 0x002664FB
		// (set) Token: 0x0601A183 RID: 106883 RVA: 0x0026830B File Offset: 0x0026650B
		public unsafe int EndFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGPUParticleMeshInfo.__PropertyOffset_EndFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGPUParticleMeshInfo.__PropertyOffset_EndFrame) = value;
			}
		}

		// Token: 0x170068C5 RID: 26821
		// (get) Token: 0x0601A184 RID: 106884 RVA: 0x0026831C File Offset: 0x0026651C
		// (set) Token: 0x0601A185 RID: 106885 RVA: 0x00268330 File Offset: 0x00266530
		public unsafe FVector BoundsCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGPUParticleMeshInfo.__PropertyOffset_BoundsCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGPUParticleMeshInfo.__PropertyOffset_BoundsCenter) = value;
			}
		}

		// Token: 0x170068C6 RID: 26822
		// (get) Token: 0x0601A186 RID: 106886 RVA: 0x00268345 File Offset: 0x00266545
		// (set) Token: 0x0601A187 RID: 106887 RVA: 0x00268359 File Offset: 0x00266559
		public unsafe FVector BoundsSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGPUParticleMeshInfo.__PropertyOffset_BoundsSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGPUParticleMeshInfo.__PropertyOffset_BoundsSize) = value;
			}
		}

		// Token: 0x170068C7 RID: 26823
		// (get) Token: 0x0601A188 RID: 106888 RVA: 0x0026836E File Offset: 0x0026656E
		// (set) Token: 0x0601A189 RID: 106889 RVA: 0x00268382 File Offset: 0x00266582
		[Nullable(2)]
		public unsafe UStaticMesh Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroGPUParticleMeshInfo.__PropertyOffset_Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroGPUParticleMeshInfo.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x0601A18A RID: 106890 RVA: 0x00268397 File Offset: 0x00266597
		public FKuroGPUParticleMeshInfo()
		{
		}

		// Token: 0x0601A18B RID: 106891 RVA: 0x0026839F File Offset: 0x0026659F
		[NullableContext(1)]
		public FKuroGPUParticleMeshInfo(int StartFrame, int EndFrame, FVector BoundsCenter, FVector BoundsSize, UStaticMesh Mesh)
		{
			this.StartFrame = StartFrame;
			this.EndFrame = EndFrame;
			this.BoundsCenter = BoundsCenter;
			this.BoundsSize = BoundsSize;
			this.Mesh = Mesh;
		}

		// Token: 0x0601A18C RID: 106892 RVA: 0x002683CC File Offset: 0x002665CC
		protected override IntPtr GetUStructPtr()
		{
			return FKuroGPUParticleMeshInfo.StaticStruct();
		}

		// Token: 0x0601A18D RID: 106893 RVA: 0x002683D8 File Offset: 0x002665D8
		[NullableContext(2)]
		public FKuroGPUParticleMeshInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A18E RID: 106894 RVA: 0x002683E2 File Offset: 0x002665E2
		public FKuroGPUParticleMeshInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A18F RID: 106895 RVA: 0x002683ED File Offset: 0x002665ED
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroGPUParticleMeshInfo(Pointer, false, true);
		}

		// Token: 0x0601A190 RID: 106896 RVA: 0x002683F7 File Offset: 0x002665F7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroGPUParticleMeshInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400E2B3 RID: 58035
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGPUParticleMeshInfo";

		// Token: 0x0400E2B4 RID: 58036
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E2B5 RID: 58037
		internal static int __PropertyOffset_StartFrame;

		// Token: 0x0400E2B6 RID: 58038
		internal static int __PropertyOffset_EndFrame;

		// Token: 0x0400E2B7 RID: 58039
		internal static int __PropertyOffset_BoundsCenter;

		// Token: 0x0400E2B8 RID: 58040
		internal static int __PropertyOffset_BoundsSize;

		// Token: 0x0400E2B9 RID: 58041
		internal static int __PropertyOffset_Mesh;
	}
}
