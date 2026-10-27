using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004AC RID: 1196
	[UnrealObjectPath("/Script/ControlRig.AimTarget")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FAimTarget : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003F94 RID: 16276 RVA: 0x0005F87E File Offset: 0x0005DA7E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAimTarget._ScriptStructPtr != 0) ? FAimTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.AimTarget", ref FAimTarget._ScriptStructPtr);
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06003F95 RID: 16277 RVA: 0x0005F8A2 File Offset: 0x0005DAA2
		// (set) Token: 0x06003F96 RID: 16278 RVA: 0x0005F8B2 File Offset: 0x0005DAB2
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAimTarget.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAimTarget.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06003F97 RID: 16279 RVA: 0x0005F8C3 File Offset: 0x0005DAC3
		// (set) Token: 0x06003F98 RID: 16280 RVA: 0x0005F8D7 File Offset: 0x0005DAD7
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAimTarget.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAimTarget.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06003F99 RID: 16281 RVA: 0x0005F8EC File Offset: 0x0005DAEC
		// (set) Token: 0x06003F9A RID: 16282 RVA: 0x0005F900 File Offset: 0x0005DB00
		public unsafe FVector AlignVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAimTarget.__PropertyOffset_AlignVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAimTarget.__PropertyOffset_AlignVector) = value;
			}
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x0005F915 File Offset: 0x0005DB15
		public FAimTarget()
		{
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x0005F91D File Offset: 0x0005DB1D
		public FAimTarget(float Weight, FTransform Transform, FVector AlignVector)
		{
			this.Weight = Weight;
			this.Transform = Transform;
			this.AlignVector = AlignVector;
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x0005F93A File Offset: 0x0005DB3A
		protected override IntPtr GetUStructPtr()
		{
			return FAimTarget.StaticStruct();
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x0005F946 File Offset: 0x0005DB46
		[NullableContext(2)]
		public FAimTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x0005F950 File Offset: 0x0005DB50
		public FAimTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x0005F95B File Offset: 0x0005DB5B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAimTarget(Pointer, false, true);
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x0005F965 File Offset: 0x0005DB65
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAimTarget(Pointer, MemoryOwner);
		}

		// Token: 0x04001E65 RID: 7781
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.AimTarget";

		// Token: 0x04001E66 RID: 7782
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001E67 RID: 7783
		internal static int __PropertyOffset_Weight;

		// Token: 0x04001E68 RID: 7784
		internal static int __PropertyOffset_Transform;

		// Token: 0x04001E69 RID: 7785
		internal static int __PropertyOffset_AlignVector;
	}
}
