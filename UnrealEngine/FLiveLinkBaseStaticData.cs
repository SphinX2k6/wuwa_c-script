using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020021F4 RID: 8692
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkBaseStaticData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLiveLinkBaseStaticData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021231 RID: 135729 RVA: 0x0030DD12 File Offset: 0x0030BF12
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkBaseStaticData._ScriptStructPtr != 0) ? FLiveLinkBaseStaticData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkBaseStaticData", ref FLiveLinkBaseStaticData._ScriptStructPtr);
		}

		// Token: 0x17008165 RID: 33125
		// (get) Token: 0x06021232 RID: 135730 RVA: 0x0030DD38 File Offset: 0x0030BF38
		// (set) Token: 0x06021233 RID: 135731 RVA: 0x0030DD7B File Offset: 0x0030BF7B
		public TArray<FName> PropertyNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._PropertyNames) == null)
				{
					result = (this._PropertyNames = new TArray<FName>(base.NativePtr + (IntPtr)FLiveLinkBaseStaticData.__PropertyOffset_PropertyNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PropertyNames.CopyAssign(value);
			}
		}

		// Token: 0x06021234 RID: 135732 RVA: 0x0030DD89 File Offset: 0x0030BF89
		public FLiveLinkBaseStaticData()
		{
		}

		// Token: 0x06021235 RID: 135733 RVA: 0x0030DD91 File Offset: 0x0030BF91
		public FLiveLinkBaseStaticData(TArray<FName> PropertyNames)
		{
			this.PropertyNames = PropertyNames;
		}

		// Token: 0x06021236 RID: 135734 RVA: 0x0030DDA0 File Offset: 0x0030BFA0
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkBaseStaticData.StaticStruct();
		}

		// Token: 0x06021237 RID: 135735 RVA: 0x0030DDAC File Offset: 0x0030BFAC
		[NullableContext(2)]
		public FLiveLinkBaseStaticData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021238 RID: 135736 RVA: 0x0030DDB6 File Offset: 0x0030BFB6
		public FLiveLinkBaseStaticData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021239 RID: 135737 RVA: 0x0030DDC1 File Offset: 0x0030BFC1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkBaseStaticData(Pointer, false, true);
		}

		// Token: 0x0602123A RID: 135738 RVA: 0x0030DDCB File Offset: 0x0030BFCB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkBaseStaticData(Pointer, MemoryOwner);
		}

		// Token: 0x04011AEC RID: 72428
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkBaseStaticData";

		// Token: 0x04011AED RID: 72429
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011AEE RID: 72430
		internal static int __PropertyOffset_PropertyNames;

		// Token: 0x04011AEF RID: 72431
		[Nullable(2)]
		private TArray<FName> _PropertyNames;
	}
}
