using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200203D RID: 8253
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIDrawableEventData")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FLGUIDrawableEventData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F35A RID: 127834 RVA: 0x002E5798 File Offset: 0x002E3998
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIDrawableEventData._ScriptStructPtr != 0) ? FLGUIDrawableEventData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIDrawableEventData", ref FLGUIDrawableEventData._ScriptStructPtr);
		}

		// Token: 0x17007BAD RID: 31661
		// (get) Token: 0x0601F35B RID: 127835 RVA: 0x002E57BC File Offset: 0x002E39BC
		// (set) Token: 0x0601F35C RID: 127836 RVA: 0x002E57D0 File Offset: 0x002E39D0
		public unsafe AActor targetActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FLGUIDrawableEventData.__PropertyOffset_targetActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLGUIDrawableEventData.__PropertyOffset_targetActor, value);
			}
		}

		// Token: 0x17007BAE RID: 31662
		// (get) Token: 0x0601F35D RID: 127837 RVA: 0x002E57E5 File Offset: 0x002E39E5
		// (set) Token: 0x0601F35E RID: 127838 RVA: 0x002E57F9 File Offset: 0x002E39F9
		public unsafe UClassStackOnlyPtr componentClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIDrawableEventData.__PropertyOffset_componentClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIDrawableEventData.__PropertyOffset_componentClass) = value;
			}
		}

		// Token: 0x17007BAF RID: 31663
		// (get) Token: 0x0601F35F RID: 127839 RVA: 0x002E580E File Offset: 0x002E3A0E
		// (set) Token: 0x0601F360 RID: 127840 RVA: 0x002E5822 File Offset: 0x002E3A22
		public unsafe FName componentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIDrawableEventData.__PropertyOffset_componentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIDrawableEventData.__PropertyOffset_componentName) = value;
			}
		}

		// Token: 0x17007BB0 RID: 31664
		// (get) Token: 0x0601F361 RID: 127841 RVA: 0x002E5837 File Offset: 0x002E3A37
		// (set) Token: 0x0601F362 RID: 127842 RVA: 0x002E584B File Offset: 0x002E3A4B
		public unsafe FName functionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIDrawableEventData.__PropertyOffset_functionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIDrawableEventData.__PropertyOffset_functionName) = value;
			}
		}

		// Token: 0x17007BB1 RID: 31665
		// (get) Token: 0x0601F363 RID: 127843 RVA: 0x002E5860 File Offset: 0x002E3A60
		// (set) Token: 0x0601F364 RID: 127844 RVA: 0x002E5870 File Offset: 0x002E3A70
		public unsafe LGUIDrawableEventParameterType ParamType
		{
			get
			{
				return (LGUIDrawableEventParameterType)(*(base.NativePtr + (IntPtr)FLGUIDrawableEventData.__PropertyOffset_ParamType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIDrawableEventData.__PropertyOffset_ParamType) = (byte)value;
			}
		}

		// Token: 0x17007BB2 RID: 31666
		// (get) Token: 0x0601F365 RID: 127845 RVA: 0x002E5884 File Offset: 0x002E3A84
		// (set) Token: 0x0601F366 RID: 127846 RVA: 0x002E58C7 File Offset: 0x002E3AC7
		[Nullable(1)]
		public TArray<byte> ParamBuffer
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ParamBuffer) == null)
				{
					result = (this._ParamBuffer = new TArray<byte>(base.NativePtr + (IntPtr)FLGUIDrawableEventData.__PropertyOffset_ParamBuffer, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ParamBuffer.CopyAssign(value);
			}
		}

		// Token: 0x17007BB3 RID: 31667
		// (get) Token: 0x0601F367 RID: 127847 RVA: 0x002E58D5 File Offset: 0x002E3AD5
		// (set) Token: 0x0601F368 RID: 127848 RVA: 0x002E58E9 File Offset: 0x002E3AE9
		public unsafe UObject ReferenceObject
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FLGUIDrawableEventData.__PropertyOffset_ReferenceObject);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLGUIDrawableEventData.__PropertyOffset_ReferenceObject, value);
			}
		}

		// Token: 0x17007BB4 RID: 31668
		// (get) Token: 0x0601F369 RID: 127849 RVA: 0x002E58FE File Offset: 0x002E3AFE
		// (set) Token: 0x0601F36A RID: 127850 RVA: 0x002E5912 File Offset: 0x002E3B12
		public unsafe AActor ReferenceActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FLGUIDrawableEventData.__PropertyOffset_ReferenceActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLGUIDrawableEventData.__PropertyOffset_ReferenceActor, value);
			}
		}

		// Token: 0x17007BB5 RID: 31669
		// (get) Token: 0x0601F36B RID: 127851 RVA: 0x002E5927 File Offset: 0x002E3B27
		// (set) Token: 0x0601F36C RID: 127852 RVA: 0x002E593B File Offset: 0x002E3B3B
		public unsafe UClassStackOnlyPtr ReferenceClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIDrawableEventData.__PropertyOffset_ReferenceClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIDrawableEventData.__PropertyOffset_ReferenceClass) = value;
			}
		}

		// Token: 0x17007BB6 RID: 31670
		// (get) Token: 0x0601F36D RID: 127853 RVA: 0x002E5950 File Offset: 0x002E3B50
		// (set) Token: 0x0601F36E RID: 127854 RVA: 0x002E5964 File Offset: 0x002E3B64
		[Nullable(1)]
		public unsafe string ReferenceString
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLGUIDrawableEventData.__PropertyOffset_ReferenceString)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLGUIDrawableEventData.__PropertyOffset_ReferenceString)), value);
			}
		}

		// Token: 0x17007BB7 RID: 31671
		// (get) Token: 0x0601F36F RID: 127855 RVA: 0x002E5979 File Offset: 0x002E3B79
		// (set) Token: 0x0601F370 RID: 127856 RVA: 0x002E5989 File Offset: 0x002E3B89
		public unsafe bool UseNativeParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLGUIDrawableEventData.__PropertyOffset_UseNativeParameter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLGUIDrawableEventData.__PropertyOffset_UseNativeParameter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007BB8 RID: 31672
		// (get) Token: 0x0601F371 RID: 127857 RVA: 0x002E599A File Offset: 0x002E3B9A
		// (set) Token: 0x0601F372 RID: 127858 RVA: 0x002E59AE File Offset: 0x002E3BAE
		public unsafe UFunction CacheFunction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFunction>(base.NativePtr / (IntPtr)sizeof(void*) + FLGUIDrawableEventData.__PropertyOffset_CacheFunction);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLGUIDrawableEventData.__PropertyOffset_CacheFunction, value);
			}
		}

		// Token: 0x17007BB9 RID: 31673
		// (get) Token: 0x0601F373 RID: 127859 RVA: 0x002E59C3 File Offset: 0x002E3BC3
		// (set) Token: 0x0601F374 RID: 127860 RVA: 0x002E59D7 File Offset: 0x002E3BD7
		public unsafe UObject CacheTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FLGUIDrawableEventData.__PropertyOffset_CacheTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLGUIDrawableEventData.__PropertyOffset_CacheTarget, value);
			}
		}

		// Token: 0x0601F375 RID: 127861 RVA: 0x002E59EC File Offset: 0x002E3BEC
		public FLGUIDrawableEventData()
		{
		}

		// Token: 0x0601F376 RID: 127862 RVA: 0x002E59F4 File Offset: 0x002E3BF4
		[NullableContext(1)]
		public FLGUIDrawableEventData(bool BoolValue, float FloatValue, double DoubleValue, sbyte Int8Value, byte UInt8Value, short Int16Value, ushort UInt16Value, int Int32Value, uint UInt32Value, long Int64Value, ulong UInt64Value, FVector2D Vector2Value, FVector Vector3Value, FVector4 Vector4Value, FQuat QuatValue, FColor ColorValue, FLinearColor LinearColorValue, FRotator RotatorValue, AActor targetActor, UClassStackOnlyPtr componentClass, FName componentName, FName functionName, LGUIDrawableEventParameterType ParamType, TArray<byte> ParamBuffer, UObject ReferenceObject, AActor ReferenceActor, UClassStackOnlyPtr ReferenceClass, string ReferenceString, bool UseNativeParameter, UFunction CacheFunction, UObject CacheTarget)
		{
			this.targetActor = targetActor;
			this.componentClass = componentClass;
			this.componentName = componentName;
			this.functionName = functionName;
			this.ParamType = ParamType;
			this.ParamBuffer = ParamBuffer;
			this.ReferenceObject = ReferenceObject;
			this.ReferenceActor = ReferenceActor;
			this.ReferenceClass = ReferenceClass;
			this.ReferenceString = ReferenceString;
			this.UseNativeParameter = UseNativeParameter;
			this.CacheFunction = CacheFunction;
			this.CacheTarget = CacheTarget;
		}

		// Token: 0x0601F377 RID: 127863 RVA: 0x002E5A6F File Offset: 0x002E3C6F
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIDrawableEventData.StaticStruct();
		}

		// Token: 0x0601F378 RID: 127864 RVA: 0x002E5A7B File Offset: 0x002E3C7B
		public FLGUIDrawableEventData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F379 RID: 127865 RVA: 0x002E5A85 File Offset: 0x002E3C85
		public FLGUIDrawableEventData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F37A RID: 127866 RVA: 0x002E5A90 File Offset: 0x002E3C90
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIDrawableEventData(Pointer, false, true);
		}

		// Token: 0x0601F37B RID: 127867 RVA: 0x002E5A9A File Offset: 0x002E3C9A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIDrawableEventData(Pointer, MemoryOwner);
		}

		// Token: 0x04010E3A RID: 69178
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEventData";

		// Token: 0x04010E3B RID: 69179
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010E3C RID: 69180
		internal static int __PropertyOffset_targetActor;

		// Token: 0x04010E3D RID: 69181
		internal static int __PropertyOffset_componentClass;

		// Token: 0x04010E3E RID: 69182
		internal static int __PropertyOffset_componentName;

		// Token: 0x04010E3F RID: 69183
		internal static int __PropertyOffset_functionName;

		// Token: 0x04010E40 RID: 69184
		internal static int __PropertyOffset_ParamType;

		// Token: 0x04010E41 RID: 69185
		internal static int __PropertyOffset_ParamBuffer;

		// Token: 0x04010E42 RID: 69186
		private TArray<byte> _ParamBuffer;

		// Token: 0x04010E43 RID: 69187
		internal static int __PropertyOffset_ReferenceObject;

		// Token: 0x04010E44 RID: 69188
		internal static int __PropertyOffset_ReferenceActor;

		// Token: 0x04010E45 RID: 69189
		internal static int __PropertyOffset_ReferenceClass;

		// Token: 0x04010E46 RID: 69190
		internal static int __PropertyOffset_ReferenceString;

		// Token: 0x04010E47 RID: 69191
		internal static int __PropertyOffset_UseNativeParameter;

		// Token: 0x04010E48 RID: 69192
		internal static int __PropertyOffset_CacheFunction;

		// Token: 0x04010E49 RID: 69193
		internal static int __PropertyOffset_CacheTarget;
	}
}
