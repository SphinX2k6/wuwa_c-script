using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200010C RID: 268
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AISense_Prediction")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UAISense_Prediction : UAISense, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001400 RID: 5120 RVA: 0x0001D860 File Offset: 0x0001BA60
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISense_Prediction._ClassPtr;
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x0001D86C File Offset: 0x0001BA6C
		public UAISense_Prediction() : this(BuiltinUtils.AllocNativeUObject(UAISense_Prediction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0001D894 File Offset: 0x0001BA94
		public UAISense_Prediction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAISense_Prediction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x0001D8C8 File Offset: 0x0001BAC8
		// (set) Token: 0x06001404 RID: 5124 RVA: 0x0001D901 File Offset: 0x0001BB01
		public TArray<FAIPredictionEvent> RegisteredEvents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAIPredictionEvent> result;
				if ((result = this._RegisteredEvents) == null)
				{
					result = (this._RegisteredEvents = new TArray<FAIPredictionEvent>(base.NativePtr + (IntPtr)UAISense_Prediction.__PropertyOffset_RegisteredEvents, this));
				}
				return result;
			}
			set
			{
				this.RegisteredEvents.CopyAssign(value);
			}
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x0001D90F File Offset: 0x0001BB0F
		[NullableContext(2)]
		public static void RequestPawnPredictionEvent(APawn Requestor, AActor PredictedActor, float PredictionTime)
		{
			UAISense_Prediction.__RequestPawnPredictionEvent_Internal((Requestor != null) ? Requestor.NativePtr : IntPtr.Zero, (PredictedActor != null) ? PredictedActor.NativePtr : IntPtr.Zero, PredictionTime);
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0001D937 File Offset: 0x0001BB37
		[NullableContext(2)]
		public static void RequestControllerPredictionEvent(AAIController Requestor, AActor PredictedActor, float PredictionTime)
		{
			UAISense_Prediction.__RequestControllerPredictionEvent_Internal((Requestor != null) ? Requestor.NativePtr : IntPtr.Zero, (PredictedActor != null) ? PredictedActor.NativePtr : IntPtr.Zero, PredictionTime);
		}

		// Token: 0x06001407 RID: 5127
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequestPawnPredictionEvent_Internal(IntPtr Requestor, IntPtr PredictedActor, float PredictionTime);

		// Token: 0x06001408 RID: 5128
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequestControllerPredictionEvent_Internal(IntPtr Requestor, IntPtr PredictedActor, float PredictionTime);

		// Token: 0x06001409 RID: 5129 RVA: 0x0001D95F File Offset: 0x0001BB5F
		static UAISense_Prediction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISense_Prediction");
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x0001D96D File Offset: 0x0001BB6D
		protected UAISense_Prediction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040003DF RID: 991
		public new const string __ObjectPath = "/Script/AIModule.AISense_Prediction";

		// Token: 0x040003E0 RID: 992
		private static IntPtr _ClassPtr;

		// Token: 0x040003E1 RID: 993
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040003E2 RID: 994
		internal static int __PropertyOffset_RegisteredEvents;

		// Token: 0x040003E3 RID: 995
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAIPredictionEvent> _RegisteredEvents;
	}
}
