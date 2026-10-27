using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BC1 RID: 7105
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSmartLightCustomParameterLinearColor")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FKuroSmartLightCustomParameterLinearColor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B41F RID: 111647 RVA: 0x00282BBA File Offset: 0x00280DBA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSmartLightCustomParameterLinearColor._ScriptStructPtr != 0) ? FKuroSmartLightCustomParameterLinearColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroSmartLightCustomParameterLinearColor", ref FKuroSmartLightCustomParameterLinearColor._ScriptStructPtr);
		}

		// Token: 0x17006D80 RID: 28032
		// (get) Token: 0x0601B420 RID: 111648 RVA: 0x00282BDE File Offset: 0x00280DDE
		// (set) Token: 0x0601B421 RID: 111649 RVA: 0x00282BF2 File Offset: 0x00280DF2
		public unsafe FName ParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSmartLightCustomParameterLinearColor.__PropertyOffset_ParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSmartLightCustomParameterLinearColor.__PropertyOffset_ParamName) = value;
			}
		}

		// Token: 0x17006D81 RID: 28033
		// (get) Token: 0x0601B422 RID: 111650 RVA: 0x00282C07 File Offset: 0x00280E07
		// (set) Token: 0x0601B423 RID: 111651 RVA: 0x00282C1B File Offset: 0x00280E1B
		public unsafe FLinearColor LightOffValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSmartLightCustomParameterLinearColor.__PropertyOffset_LightOffValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSmartLightCustomParameterLinearColor.__PropertyOffset_LightOffValue) = value;
			}
		}

		// Token: 0x17006D82 RID: 28034
		// (get) Token: 0x0601B424 RID: 111652 RVA: 0x00282C30 File Offset: 0x00280E30
		// (set) Token: 0x0601B425 RID: 111653 RVA: 0x00282C44 File Offset: 0x00280E44
		public unsafe FLinearColor LightOnValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSmartLightCustomParameterLinearColor.__PropertyOffset_LightOnValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSmartLightCustomParameterLinearColor.__PropertyOffset_LightOnValue) = value;
			}
		}

		// Token: 0x0601B426 RID: 111654 RVA: 0x00282C59 File Offset: 0x00280E59
		public FKuroSmartLightCustomParameterLinearColor()
		{
		}

		// Token: 0x0601B427 RID: 111655 RVA: 0x00282C61 File Offset: 0x00280E61
		public FKuroSmartLightCustomParameterLinearColor(FName ParamName, FLinearColor LightOffValue, FLinearColor LightOnValue)
		{
			this.ParamName = ParamName;
			this.LightOffValue = LightOffValue;
			this.LightOnValue = LightOnValue;
		}

		// Token: 0x0601B428 RID: 111656 RVA: 0x00282C7E File Offset: 0x00280E7E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSmartLightCustomParameterLinearColor.StaticStruct();
		}

		// Token: 0x0601B429 RID: 111657 RVA: 0x00282C8A File Offset: 0x00280E8A
		[NullableContext(2)]
		public FKuroSmartLightCustomParameterLinearColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B42A RID: 111658 RVA: 0x00282C94 File Offset: 0x00280E94
		public FKuroSmartLightCustomParameterLinearColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B42B RID: 111659 RVA: 0x00282C9F File Offset: 0x00280E9F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSmartLightCustomParameterLinearColor(Pointer, false, true);
		}

		// Token: 0x0601B42C RID: 111660 RVA: 0x00282CA9 File Offset: 0x00280EA9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSmartLightCustomParameterLinearColor(Pointer, MemoryOwner);
		}

		// Token: 0x0400EAE8 RID: 60136
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSmartLightCustomParameterLinearColor";

		// Token: 0x0400EAE9 RID: 60137
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EAEA RID: 60138
		internal static int __PropertyOffset_ParamName;

		// Token: 0x0400EAEB RID: 60139
		internal static int __PropertyOffset_LightOffValue;

		// Token: 0x0400EAEC RID: 60140
		internal static int __PropertyOffset_LightOnValue;
	}
}
