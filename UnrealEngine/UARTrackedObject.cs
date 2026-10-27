using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003D4 RID: 980
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARTrackedObject")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UARTrackedObject : UARTrackedGeometry, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003705 RID: 14085 RVA: 0x0005382B File Offset: 0x00051A2B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARTrackedObject._ClassPtr;
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x00053838 File Offset: 0x00051A38
		public UARTrackedObject() : this(BuiltinUtils.AllocNativeUObject(UARTrackedObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x00053860 File Offset: 0x00051A60
		[NullableContext(1)]
		public UARTrackedObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARTrackedObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06003708 RID: 14088 RVA: 0x00053893 File Offset: 0x00051A93
		// (set) Token: 0x06003709 RID: 14089 RVA: 0x000538A7 File Offset: 0x00051AA7
		public unsafe UARCandidateObject DetectedObject
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UARCandidateObject>(base.NativePtr / (IntPtr)sizeof(void*) + UARTrackedObject.__PropertyOffset_DetectedObject);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UARTrackedObject.__PropertyOffset_DetectedObject, value);
			}
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x000538BC File Offset: 0x00051ABC
		public UARCandidateObject GetDetectedObject()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARCandidateObject>(UARTrackedObject.__GetDetectedObject_Internal(base.NativePtr));
		}

		// Token: 0x0600370B RID: 14091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDetectedObject_Internal(IntPtr @this);

		// Token: 0x0600370C RID: 14092 RVA: 0x000538CE File Offset: 0x00051ACE
		static UARTrackedObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARTrackedObject");
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x000538DC File Offset: 0x00051ADC
		protected UARTrackedObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040017DA RID: 6106
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARTrackedObject";

		// Token: 0x040017DB RID: 6107
		private static IntPtr _ClassPtr;

		// Token: 0x040017DC RID: 6108
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040017DD RID: 6109
		internal static int __PropertyOffset_DetectedObject;
	}
}
