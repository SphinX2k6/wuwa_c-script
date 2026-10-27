using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003A1 RID: 929
	[UnrealObjectPath("/Script/AugmentedReality.ARFaceComponent")]
	[UnrealStructLayout(800, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 800)]
	public class UARFaceComponent : UARComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003377 RID: 13175 RVA: 0x0004ECBC File Offset: 0x0004CEBC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARFaceComponent._ClassPtr;
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x0004ECC8 File Offset: 0x0004CEC8
		public UARFaceComponent() : this(BuiltinUtils.AllocNativeUObject(UARFaceComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x0004ECF0 File Offset: 0x0004CEF0
		[NullableContext(1)]
		public UARFaceComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARFaceComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x0600337A RID: 13178 RVA: 0x0004ED23 File Offset: 0x0004CF23
		// (set) Token: 0x0600337B RID: 13179 RVA: 0x0004ED33 File Offset: 0x0004CF33
		public unsafe EARFaceTransformMixing TransformSetting
		{
			get
			{
				return (EARFaceTransformMixing)(*(base.NativePtr + (IntPtr)UARFaceComponent.__PropertyOffset_TransformSetting));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARFaceComponent.__PropertyOffset_TransformSetting) = (byte)value;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x0600337C RID: 13180 RVA: 0x0004ED44 File Offset: 0x0004CF44
		// (set) Token: 0x0600337D RID: 13181 RVA: 0x0004ED54 File Offset: 0x0004CF54
		public unsafe bool bUpdateVertexNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARFaceComponent.__PropertyOffset_bUpdateVertexNormal) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARFaceComponent.__PropertyOffset_bUpdateVertexNormal) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x0600337E RID: 13182 RVA: 0x0004ED65 File Offset: 0x0004CF65
		// (set) Token: 0x0600337F RID: 13183 RVA: 0x0004ED75 File Offset: 0x0004CF75
		public unsafe bool bFaceOutOfScreen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARFaceComponent.__PropertyOffset_bFaceOutOfScreen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARFaceComponent.__PropertyOffset_bFaceOutOfScreen) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06003380 RID: 13184 RVA: 0x0004ED88 File Offset: 0x0004CF88
		// (set) Token: 0x06003381 RID: 13185 RVA: 0x0004EDC1 File Offset: 0x0004CFC1
		[Nullable(1)]
		public FARFaceUpdatePayload ReplicatedPayload
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FARFaceUpdatePayload result;
				if ((result = this._ReplicatedPayload) == null)
				{
					result = (this._ReplicatedPayload = new FARFaceUpdatePayload(base.NativePtr + (IntPtr)UARFaceComponent.__PropertyOffset_ReplicatedPayload, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARFaceUpdatePayload.StaticStruct(), base.NativePtr + (IntPtr)UARFaceComponent.__PropertyOffset_ReplicatedPayload, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06003382 RID: 13186
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetFaceComponentDebugMode(EFaceComponentDebugMode NewDebugMode);

		// Token: 0x06003383 RID: 13187 RVA: 0x0004EDE2 File Offset: 0x0004CFE2
		[NullableContext(2)]
		public void ServerUpdatePayload(in FARFaceUpdatePayload NewPayload)
		{
			UARFaceComponent.__ServerUpdatePayload_Internal(base.NativePtr, (NewPayload ?? new FARFaceUpdatePayload()).NativePtr);
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x0004EDFF File Offset: 0x0004CFFF
		[NullableContext(2)]
		public virtual void ReceiveUpdate(in FARFaceUpdatePayload Payload)
		{
			UARFaceComponent.__ReceiveUpdate_Internal(base.NativePtr, (Payload ?? new FARFaceUpdatePayload()).NativePtr);
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x0004EE1C File Offset: 0x0004D01C
		[NullableContext(2)]
		public virtual void ReceiveAdd(in FARFaceUpdatePayload Payload)
		{
			UARFaceComponent.__ReceiveAdd_Internal(base.NativePtr, (Payload ?? new FARFaceUpdatePayload()).NativePtr);
		}

		// Token: 0x06003386 RID: 13190
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerUpdatePayload_Internal(IntPtr @this, IntPtr NewPayload);

		// Token: 0x06003387 RID: 13191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveUpdate_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x06003388 RID: 13192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveAdd_Internal(IntPtr @this, IntPtr Payload);

		// Token: 0x06003389 RID: 13193 RVA: 0x0004EE39 File Offset: 0x0004D039
		static UARFaceComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARFaceComponent");
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x0004EE47 File Offset: 0x0004D047
		protected UARFaceComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400165B RID: 5723
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARFaceComponent";

		// Token: 0x0400165C RID: 5724
		private static IntPtr _ClassPtr;

		// Token: 0x0400165D RID: 5725
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400165E RID: 5726
		internal static int __PropertyOffset_TransformSetting;

		// Token: 0x0400165F RID: 5727
		internal static int __PropertyOffset_bUpdateVertexNormal;

		// Token: 0x04001660 RID: 5728
		internal static int __PropertyOffset_bFaceOutOfScreen;

		// Token: 0x04001661 RID: 5729
		internal static int __PropertyOffset_ReplicatedPayload;

		// Token: 0x04001662 RID: 5730
		[Nullable(2)]
		private FARFaceUpdatePayload _ReplicatedPayload;

		// Token: 0x02002C05 RID: 11269
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __ReceiveUpdate_FunctionParams
		{
			// Token: 0x04016506 RID: 91398
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x02002C06 RID: 11270
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __ReceiveAdd_FunctionParams
		{
			// Token: 0x04016507 RID: 91399
			[FieldOffset(0)]
			public byte Payload;
		}
	}
}
