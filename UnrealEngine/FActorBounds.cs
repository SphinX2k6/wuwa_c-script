using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022B3 RID: 8883
	[UnrealObjectPath("/Script/MeshBlend.ActorBounds")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FActorBounds : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021C2D RID: 138285 RVA: 0x0031EA9B File Offset: 0x0031CC9B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorBounds._ScriptStructPtr != 0) ? FActorBounds._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshBlend.ActorBounds", ref FActorBounds._ScriptStructPtr);
		}

		// Token: 0x170082F8 RID: 33528
		// (get) Token: 0x06021C2E RID: 138286 RVA: 0x0031EABF File Offset: 0x0031CCBF
		// (set) Token: 0x06021C2F RID: 138287 RVA: 0x0031EAD3 File Offset: 0x0031CCD3
		public unsafe FVector Origin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorBounds.__PropertyOffset_Origin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorBounds.__PropertyOffset_Origin) = value;
			}
		}

		// Token: 0x170082F9 RID: 33529
		// (get) Token: 0x06021C30 RID: 138288 RVA: 0x0031EAE8 File Offset: 0x0031CCE8
		// (set) Token: 0x06021C31 RID: 138289 RVA: 0x0031EAF8 File Offset: 0x0031CCF8
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorBounds.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorBounds.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x06021C32 RID: 138290 RVA: 0x0031EB09 File Offset: 0x0031CD09
		public FActorBounds()
		{
		}

		// Token: 0x06021C33 RID: 138291 RVA: 0x0031EB11 File Offset: 0x0031CD11
		public FActorBounds(FVector Origin, float Radius)
		{
			this.Origin = Origin;
			this.Radius = Radius;
		}

		// Token: 0x06021C34 RID: 138292 RVA: 0x0031EB27 File Offset: 0x0031CD27
		protected override IntPtr GetUStructPtr()
		{
			return FActorBounds.StaticStruct();
		}

		// Token: 0x06021C35 RID: 138293 RVA: 0x0031EB33 File Offset: 0x0031CD33
		[NullableContext(2)]
		public FActorBounds(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021C36 RID: 138294 RVA: 0x0031EB3D File Offset: 0x0031CD3D
		public FActorBounds(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021C37 RID: 138295 RVA: 0x0031EB48 File Offset: 0x0031CD48
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorBounds(Pointer, false, true);
		}

		// Token: 0x06021C38 RID: 138296 RVA: 0x0031EB52 File Offset: 0x0031CD52
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorBounds(Pointer, MemoryOwner);
		}

		// Token: 0x0401203B RID: 73787
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MeshBlend.ActorBounds";

		// Token: 0x0401203C RID: 73788
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401203D RID: 73789
		internal static int __PropertyOffset_Origin;

		// Token: 0x0401203E RID: 73790
		internal static int __PropertyOffset_Radius;
	}
}
