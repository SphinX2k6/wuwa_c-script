using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007A3 RID: 1955
	[UnrealObjectPath("/Script/Engine.ActiveCameraShakeInfo")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FActiveCameraShakeInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060065E7 RID: 26087 RVA: 0x0009219C File Offset: 0x0009039C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActiveCameraShakeInfo._ScriptStructPtr != 0) ? FActiveCameraShakeInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActiveCameraShakeInfo", ref FActiveCameraShakeInfo._ScriptStructPtr);
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x060065E8 RID: 26088 RVA: 0x000921C0 File Offset: 0x000903C0
		// (set) Token: 0x060065E9 RID: 26089 RVA: 0x000921D4 File Offset: 0x000903D4
		[Nullable(2)]
		public unsafe UCameraShakeBase ShakeInstance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraShakeBase>(base.NativePtr / (IntPtr)sizeof(void*) + FActiveCameraShakeInfo.__PropertyOffset_ShakeInstance);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FActiveCameraShakeInfo.__PropertyOffset_ShakeInstance, value);
			}
		}

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x060065EA RID: 26090 RVA: 0x000921E9 File Offset: 0x000903E9
		// (set) Token: 0x060065EB RID: 26091 RVA: 0x000921FD File Offset: 0x000903FD
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UCameraShakeSourceComponent> ShakeSource
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FActiveCameraShakeInfo.__PropertyOffset_ShakeSource);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FActiveCameraShakeInfo.__PropertyOffset_ShakeSource) = value;
			}
		}

		// Token: 0x060065EC RID: 26092 RVA: 0x00092212 File Offset: 0x00090412
		public FActiveCameraShakeInfo()
		{
		}

		// Token: 0x060065ED RID: 26093 RVA: 0x0009221A File Offset: 0x0009041A
		[NullableContext(1)]
		public FActiveCameraShakeInfo(UCameraShakeBase ShakeInstance, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UCameraShakeSourceComponent> ShakeSource)
		{
			this.ShakeInstance = ShakeInstance;
			this.ShakeSource = ShakeSource;
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x00092230 File Offset: 0x00090430
		protected override IntPtr GetUStructPtr()
		{
			return FActiveCameraShakeInfo.StaticStruct();
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x0009223C File Offset: 0x0009043C
		[NullableContext(2)]
		public FActiveCameraShakeInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060065F0 RID: 26096 RVA: 0x00092246 File Offset: 0x00090446
		public FActiveCameraShakeInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060065F1 RID: 26097 RVA: 0x00092251 File Offset: 0x00090451
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActiveCameraShakeInfo(Pointer, false, true);
		}

		// Token: 0x060065F2 RID: 26098 RVA: 0x0009225B File Offset: 0x0009045B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActiveCameraShakeInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003179 RID: 12665
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActiveCameraShakeInfo";

		// Token: 0x0400317A RID: 12666
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400317B RID: 12667
		internal static int __PropertyOffset_ShakeInstance;

		// Token: 0x0400317C RID: 12668
		internal static int __PropertyOffset_ShakeSource;
	}
}
