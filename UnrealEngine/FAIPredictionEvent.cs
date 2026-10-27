using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000F6 RID: 246
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AIPredictionEvent")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FAIPredictionEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600133A RID: 4922 RVA: 0x0001C6EB File Offset: 0x0001A8EB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAIPredictionEvent._ScriptStructPtr != 0) ? FAIPredictionEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.AIPredictionEvent", ref FAIPredictionEvent._ScriptStructPtr);
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x0001C70F File Offset: 0x0001A90F
		// (set) Token: 0x0600133C RID: 4924 RVA: 0x0001C723 File Offset: 0x0001A923
		public unsafe AActor Requestor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FAIPredictionEvent.__PropertyOffset_Requestor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAIPredictionEvent.__PropertyOffset_Requestor, value);
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x0001C738 File Offset: 0x0001A938
		// (set) Token: 0x0600133E RID: 4926 RVA: 0x0001C74C File Offset: 0x0001A94C
		public unsafe AActor PredictedActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FAIPredictionEvent.__PropertyOffset_PredictedActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAIPredictionEvent.__PropertyOffset_PredictedActor, value);
			}
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0001C761 File Offset: 0x0001A961
		public FAIPredictionEvent()
		{
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0001C769 File Offset: 0x0001A969
		[NullableContext(1)]
		public FAIPredictionEvent(AActor Requestor, AActor PredictedActor)
		{
			this.Requestor = Requestor;
			this.PredictedActor = PredictedActor;
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0001C77F File Offset: 0x0001A97F
		protected override IntPtr GetUStructPtr()
		{
			return FAIPredictionEvent.StaticStruct();
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0001C78B File Offset: 0x0001A98B
		public FAIPredictionEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0001C795 File Offset: 0x0001A995
		public FAIPredictionEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0001C7A0 File Offset: 0x0001A9A0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAIPredictionEvent(Pointer, false, true);
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0001C7AA File Offset: 0x0001A9AA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAIPredictionEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04000375 RID: 885
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.AIPredictionEvent";

		// Token: 0x04000376 RID: 886
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000377 RID: 887
		internal static int __PropertyOffset_Requestor;

		// Token: 0x04000378 RID: 888
		internal static int __PropertyOffset_PredictedActor;
	}
}
