using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001966 RID: 6502
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.KuroGameplayParameterContainer")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroGameplayParameterContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060182D2 RID: 99026 RVA: 0x00239FF7 File Offset: 0x002381F7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGameplayParameterContainer._ScriptStructPtr != 0) ? FKuroGameplayParameterContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGAS.KuroGameplayParameterContainer", ref FKuroGameplayParameterContainer._ScriptStructPtr);
		}

		// Token: 0x170060E0 RID: 24800
		// (get) Token: 0x060182D3 RID: 99027 RVA: 0x0023A01C File Offset: 0x0023821C
		// (set) Token: 0x060182D4 RID: 99028 RVA: 0x0023A05F File Offset: 0x0023825F
		public TArray<FKuroGameplayParameter> Parameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroGameplayParameter> result;
				if ((result = this._Parameters) == null)
				{
					result = (this._Parameters = new TArray<FKuroGameplayParameter>(base.NativePtr + (IntPtr)FKuroGameplayParameterContainer.__PropertyOffset_Parameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Parameters.CopyAssign(value);
			}
		}

		// Token: 0x060182D5 RID: 99029 RVA: 0x0023A06D File Offset: 0x0023826D
		public FKuroGameplayParameterContainer()
		{
		}

		// Token: 0x060182D6 RID: 99030 RVA: 0x0023A075 File Offset: 0x00238275
		public FKuroGameplayParameterContainer(TArray<FKuroGameplayParameter> Parameters)
		{
			this.Parameters = Parameters;
		}

		// Token: 0x060182D7 RID: 99031 RVA: 0x0023A084 File Offset: 0x00238284
		protected override IntPtr GetUStructPtr()
		{
			return FKuroGameplayParameterContainer.StaticStruct();
		}

		// Token: 0x060182D8 RID: 99032 RVA: 0x0023A090 File Offset: 0x00238290
		[NullableContext(2)]
		public FKuroGameplayParameterContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060182D9 RID: 99033 RVA: 0x0023A09A File Offset: 0x0023829A
		public FKuroGameplayParameterContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060182DA RID: 99034 RVA: 0x0023A0A5 File Offset: 0x002382A5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroGameplayParameterContainer(Pointer, false, true);
		}

		// Token: 0x060182DB RID: 99035 RVA: 0x0023A0AF File Offset: 0x002382AF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroGameplayParameterContainer(Pointer, MemoryOwner);
		}

		// Token: 0x0400D1A7 RID: 53671
		public const string __ObjectPath = "/Script/KuroGAS.KuroGameplayParameterContainer";

		// Token: 0x0400D1A8 RID: 53672
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D1A9 RID: 53673
		internal static int __PropertyOffset_Parameters;

		// Token: 0x0400D1AA RID: 53674
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroGameplayParameter> _Parameters;
	}
}
