using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004B2 RID: 1202
	[UnrealObjectPath("/Script/ControlRig.BlendTarget")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FBlendTarget : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003FFA RID: 16378 RVA: 0x000603B8 File Offset: 0x0005E5B8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlendTarget._ScriptStructPtr != 0) ? FBlendTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.BlendTarget", ref FBlendTarget._ScriptStructPtr);
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06003FFB RID: 16379 RVA: 0x000603DC File Offset: 0x0005E5DC
		// (set) Token: 0x06003FFC RID: 16380 RVA: 0x000603F0 File Offset: 0x0005E5F0
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlendTarget.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlendTarget.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06003FFD RID: 16381 RVA: 0x00060405 File Offset: 0x0005E605
		// (set) Token: 0x06003FFE RID: 16382 RVA: 0x00060415 File Offset: 0x0005E615
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlendTarget.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlendTarget.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x00060426 File Offset: 0x0005E626
		public FBlendTarget()
		{
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x0006042E File Offset: 0x0005E62E
		public FBlendTarget(FTransform Transform, float Weight)
		{
			this.Transform = Transform;
			this.Weight = Weight;
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x00060444 File Offset: 0x0005E644
		protected override IntPtr GetUStructPtr()
		{
			return FBlendTarget.StaticStruct();
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x00060450 File Offset: 0x0005E650
		[NullableContext(2)]
		public FBlendTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004003 RID: 16387 RVA: 0x0006045A File Offset: 0x0005E65A
		public FBlendTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004004 RID: 16388 RVA: 0x00060465 File Offset: 0x0005E665
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlendTarget(Pointer, false, true);
		}

		// Token: 0x06004005 RID: 16389 RVA: 0x0006046F File Offset: 0x0005E66F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlendTarget(Pointer, MemoryOwner);
		}

		// Token: 0x04001E9B RID: 7835
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.BlendTarget";

		// Token: 0x04001E9C RID: 7836
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001E9D RID: 7837
		internal static int __PropertyOffset_Transform;

		// Token: 0x04001E9E RID: 7838
		internal static int __PropertyOffset_Weight;
	}
}
