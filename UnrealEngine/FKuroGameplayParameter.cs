using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001965 RID: 6501
	[UnrealObjectPath("/Script/KuroGAS.KuroGameplayParameter")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroGameplayParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060182C6 RID: 99014 RVA: 0x00239F37 File Offset: 0x00238137
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGameplayParameter._ScriptStructPtr != 0) ? FKuroGameplayParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGAS.KuroGameplayParameter", ref FKuroGameplayParameter._ScriptStructPtr);
		}

		// Token: 0x170060DE RID: 24798
		// (get) Token: 0x060182C7 RID: 99015 RVA: 0x00239F5B File Offset: 0x0023815B
		// (set) Token: 0x060182C8 RID: 99016 RVA: 0x00239F6F File Offset: 0x0023816F
		public unsafe FGameplayTag ParameterTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGameplayParameter.__PropertyOffset_ParameterTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameplayParameter.__PropertyOffset_ParameterTag) = value;
			}
		}

		// Token: 0x170060DF RID: 24799
		// (get) Token: 0x060182C9 RID: 99017 RVA: 0x00239F84 File Offset: 0x00238184
		// (set) Token: 0x060182CA RID: 99018 RVA: 0x00239F94 File Offset: 0x00238194
		public unsafe float ParameterValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroGameplayParameter.__PropertyOffset_ParameterValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroGameplayParameter.__PropertyOffset_ParameterValue) = value;
			}
		}

		// Token: 0x060182CB RID: 99019 RVA: 0x00239FA5 File Offset: 0x002381A5
		public FKuroGameplayParameter()
		{
		}

		// Token: 0x060182CC RID: 99020 RVA: 0x00239FAD File Offset: 0x002381AD
		public FKuroGameplayParameter(FGameplayTag ParameterTag, float ParameterValue)
		{
			this.ParameterTag = ParameterTag;
			this.ParameterValue = ParameterValue;
		}

		// Token: 0x060182CD RID: 99021 RVA: 0x00239FC3 File Offset: 0x002381C3
		protected override IntPtr GetUStructPtr()
		{
			return FKuroGameplayParameter.StaticStruct();
		}

		// Token: 0x060182CE RID: 99022 RVA: 0x00239FCF File Offset: 0x002381CF
		[NullableContext(2)]
		public FKuroGameplayParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060182CF RID: 99023 RVA: 0x00239FD9 File Offset: 0x002381D9
		public FKuroGameplayParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060182D0 RID: 99024 RVA: 0x00239FE4 File Offset: 0x002381E4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroGameplayParameter(Pointer, false, true);
		}

		// Token: 0x060182D1 RID: 99025 RVA: 0x00239FEE File Offset: 0x002381EE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroGameplayParameter(Pointer, MemoryOwner);
		}

		// Token: 0x0400D1A3 RID: 53667
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.KuroGameplayParameter";

		// Token: 0x0400D1A4 RID: 53668
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D1A5 RID: 53669
		internal static int __PropertyOffset_ParameterTag;

		// Token: 0x0400D1A6 RID: 53670
		internal static int __PropertyOffset_ParameterValue;
	}
}
