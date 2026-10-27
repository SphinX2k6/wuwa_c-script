using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003A2 RID: 930
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARFaceGeometry")]
	[UnrealStructLayout(496, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UARFaceGeometry : UARTrackedGeometry, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600338B RID: 13195 RVA: 0x0004EE50 File Offset: 0x0004D050
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARFaceGeometry._ClassPtr;
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x0004EE5C File Offset: 0x0004D05C
		public UARFaceGeometry() : this(BuiltinUtils.AllocNativeUObject(UARFaceGeometry.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x0004EE84 File Offset: 0x0004D084
		public UARFaceGeometry(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARFaceGeometry.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x0600338E RID: 13198 RVA: 0x0004EEB7 File Offset: 0x0004D0B7
		// (set) Token: 0x0600338F RID: 13199 RVA: 0x0004EECB File Offset: 0x0004D0CB
		public unsafe FVector LookAtTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARFaceGeometry.__PropertyOffset_LookAtTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARFaceGeometry.__PropertyOffset_LookAtTarget) = value;
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06003390 RID: 13200 RVA: 0x0004EEE0 File Offset: 0x0004D0E0
		// (set) Token: 0x06003391 RID: 13201 RVA: 0x0004EEF0 File Offset: 0x0004D0F0
		public unsafe bool bIsTracked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARFaceGeometry.__PropertyOffset_bIsTracked) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARFaceGeometry.__PropertyOffset_bIsTracked) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06003392 RID: 13202 RVA: 0x0004EF04 File Offset: 0x0004D104
		// (set) Token: 0x06003393 RID: 13203 RVA: 0x0004EF3D File Offset: 0x0004D13D
		public TMap<EARFaceBlendShape, float> BlendShapes
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EARFaceBlendShape, float> result;
				if ((result = this._BlendShapes) == null)
				{
					result = (this._BlendShapes = new TMap<EARFaceBlendShape, float>(base.NativePtr + (IntPtr)UARFaceGeometry.__PropertyOffset_BlendShapes, this));
				}
				return result;
			}
			set
			{
				this.BlendShapes.CopyAssign(value);
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06003394 RID: 13204 RVA: 0x0004EF4B File Offset: 0x0004D14B
		// (set) Token: 0x06003395 RID: 13205 RVA: 0x0004EF5F File Offset: 0x0004D15F
		public unsafe FTransform LeftEyeTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARFaceGeometry.__PropertyOffset_LeftEyeTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARFaceGeometry.__PropertyOffset_LeftEyeTransform) = value;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06003396 RID: 13206 RVA: 0x0004EF74 File Offset: 0x0004D174
		// (set) Token: 0x06003397 RID: 13207 RVA: 0x0004EF88 File Offset: 0x0004D188
		public unsafe FTransform RightEyeTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARFaceGeometry.__PropertyOffset_RightEyeTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARFaceGeometry.__PropertyOffset_RightEyeTransform) = value;
			}
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x0004EF9D File Offset: 0x0004D19D
		public FTransform GetWorldSpaceEyeTransform(EAREye Eye)
		{
			return UARFaceGeometry.__GetWorldSpaceEyeTransform_Internal(base.NativePtr, Eye);
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x0004EFAB File Offset: 0x0004D1AB
		public FTransform GetLocalSpaceEyeTransform(EAREye Eye)
		{
			return UARFaceGeometry.__GetLocalSpaceEyeTransform_Internal(base.NativePtr, Eye);
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x0004EFB9 File Offset: 0x0004D1B9
		public float GetBlendShapeValue(EARFaceBlendShape BlendShape)
		{
			return UARFaceGeometry.__GetBlendShapeValue_Internal(base.NativePtr, BlendShape);
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x0004EFC7 File Offset: 0x0004D1C7
		public TMap<EARFaceBlendShape, float> GetBlendShapes()
		{
			return new TMap<EARFaceBlendShape, float>(UARFaceGeometry.__GetBlendShapes_Internal(base.NativePtr), null);
		}

		// Token: 0x0600339C RID: 13212
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetWorldSpaceEyeTransform_Internal(IntPtr @this, EAREye Eye);

		// Token: 0x0600339D RID: 13213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetLocalSpaceEyeTransform_Internal(IntPtr @this, EAREye Eye);

		// Token: 0x0600339E RID: 13214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBlendShapeValue_Internal(IntPtr @this, EARFaceBlendShape BlendShape);

		// Token: 0x0600339F RID: 13215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBlendShapes_Internal(IntPtr @this);

		// Token: 0x060033A0 RID: 13216 RVA: 0x0004EFDA File Offset: 0x0004D1DA
		static UARFaceGeometry()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARFaceGeometry");
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x0004EFE8 File Offset: 0x0004D1E8
		protected UARFaceGeometry(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001663 RID: 5731
		public new const string __ObjectPath = "/Script/AugmentedReality.ARFaceGeometry";

		// Token: 0x04001664 RID: 5732
		private static IntPtr _ClassPtr;

		// Token: 0x04001665 RID: 5733
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001666 RID: 5734
		internal static int __PropertyOffset_LookAtTarget;

		// Token: 0x04001667 RID: 5735
		internal static int __PropertyOffset_bIsTracked;

		// Token: 0x04001668 RID: 5736
		internal static int __PropertyOffset_BlendShapes;

		// Token: 0x04001669 RID: 5737
		[Nullable(2)]
		private TMap<EARFaceBlendShape, float> _BlendShapes;

		// Token: 0x0400166A RID: 5738
		internal static int __PropertyOffset_LeftEyeTransform;

		// Token: 0x0400166B RID: 5739
		internal static int __PropertyOffset_RightEyeTransform;
	}
}
