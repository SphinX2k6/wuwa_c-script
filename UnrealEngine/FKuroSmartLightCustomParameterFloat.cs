using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BC0 RID: 7104
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSmartLightCustomParameterFloat")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FKuroSmartLightCustomParameterFloat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B411 RID: 111633 RVA: 0x00282AD2 File Offset: 0x00280CD2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSmartLightCustomParameterFloat._ScriptStructPtr != 0) ? FKuroSmartLightCustomParameterFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroSmartLightCustomParameterFloat", ref FKuroSmartLightCustomParameterFloat._ScriptStructPtr);
		}

		// Token: 0x17006D7D RID: 28029
		// (get) Token: 0x0601B412 RID: 111634 RVA: 0x00282AF6 File Offset: 0x00280CF6
		// (set) Token: 0x0601B413 RID: 111635 RVA: 0x00282B0A File Offset: 0x00280D0A
		public unsafe FName ParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSmartLightCustomParameterFloat.__PropertyOffset_ParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSmartLightCustomParameterFloat.__PropertyOffset_ParamName) = value;
			}
		}

		// Token: 0x17006D7E RID: 28030
		// (get) Token: 0x0601B414 RID: 111636 RVA: 0x00282B1F File Offset: 0x00280D1F
		// (set) Token: 0x0601B415 RID: 111637 RVA: 0x00282B2F File Offset: 0x00280D2F
		public unsafe float LightOffValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSmartLightCustomParameterFloat.__PropertyOffset_LightOffValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSmartLightCustomParameterFloat.__PropertyOffset_LightOffValue) = value;
			}
		}

		// Token: 0x17006D7F RID: 28031
		// (get) Token: 0x0601B416 RID: 111638 RVA: 0x00282B40 File Offset: 0x00280D40
		// (set) Token: 0x0601B417 RID: 111639 RVA: 0x00282B50 File Offset: 0x00280D50
		public unsafe float LightOnValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSmartLightCustomParameterFloat.__PropertyOffset_LightOnValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSmartLightCustomParameterFloat.__PropertyOffset_LightOnValue) = value;
			}
		}

		// Token: 0x0601B418 RID: 111640 RVA: 0x00282B61 File Offset: 0x00280D61
		public FKuroSmartLightCustomParameterFloat()
		{
		}

		// Token: 0x0601B419 RID: 111641 RVA: 0x00282B69 File Offset: 0x00280D69
		public FKuroSmartLightCustomParameterFloat(FName ParamName, float LightOffValue, float LightOnValue)
		{
			this.ParamName = ParamName;
			this.LightOffValue = LightOffValue;
			this.LightOnValue = LightOnValue;
		}

		// Token: 0x0601B41A RID: 111642 RVA: 0x00282B86 File Offset: 0x00280D86
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSmartLightCustomParameterFloat.StaticStruct();
		}

		// Token: 0x0601B41B RID: 111643 RVA: 0x00282B92 File Offset: 0x00280D92
		[NullableContext(2)]
		public FKuroSmartLightCustomParameterFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B41C RID: 111644 RVA: 0x00282B9C File Offset: 0x00280D9C
		public FKuroSmartLightCustomParameterFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B41D RID: 111645 RVA: 0x00282BA7 File Offset: 0x00280DA7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSmartLightCustomParameterFloat(Pointer, false, true);
		}

		// Token: 0x0601B41E RID: 111646 RVA: 0x00282BB1 File Offset: 0x00280DB1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSmartLightCustomParameterFloat(Pointer, MemoryOwner);
		}

		// Token: 0x0400EAE3 RID: 60131
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSmartLightCustomParameterFloat";

		// Token: 0x0400EAE4 RID: 60132
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EAE5 RID: 60133
		internal static int __PropertyOffset_ParamName;

		// Token: 0x0400EAE6 RID: 60134
		internal static int __PropertyOffset_LightOffValue;

		// Token: 0x0400EAE7 RID: 60135
		internal static int __PropertyOffset_LightOnValue;
	}
}
