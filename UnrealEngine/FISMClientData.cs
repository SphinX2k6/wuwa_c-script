using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CBD RID: 3261
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ISMClientData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FISMClientData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A4DF RID: 42207 RVA: 0x000EA964 File Offset: 0x000E8B64
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FISMClientData._ScriptStructPtr != 0) ? FISMClientData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ISMClientData", ref FISMClientData._ScriptStructPtr);
		}

		// Token: 0x1700273D RID: 10045
		// (get) Token: 0x0600A4E0 RID: 42208 RVA: 0x000EA988 File Offset: 0x000E8B88
		// (set) Token: 0x0600A4E1 RID: 42209 RVA: 0x000EA9CB File Offset: 0x000E8BCB
		public TArray<FISMClientInstance> Instances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FISMClientInstance> result;
				if ((result = this._Instances) == null)
				{
					result = (this._Instances = new TArray<FISMClientInstance>(base.NativePtr + (IntPtr)FISMClientData.__PropertyOffset_Instances, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Instances.CopyAssign(value);
			}
		}

		// Token: 0x0600A4E2 RID: 42210 RVA: 0x000EA9D9 File Offset: 0x000E8BD9
		public FISMClientData()
		{
		}

		// Token: 0x0600A4E3 RID: 42211 RVA: 0x000EA9E1 File Offset: 0x000E8BE1
		public FISMClientData(TArray<FISMClientInstance> Instances)
		{
			this.Instances = Instances;
		}

		// Token: 0x0600A4E4 RID: 42212 RVA: 0x000EA9F0 File Offset: 0x000E8BF0
		protected override IntPtr GetUStructPtr()
		{
			return FISMClientData.StaticStruct();
		}

		// Token: 0x0600A4E5 RID: 42213 RVA: 0x000EA9FC File Offset: 0x000E8BFC
		[NullableContext(2)]
		public FISMClientData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A4E6 RID: 42214 RVA: 0x000EAA06 File Offset: 0x000E8C06
		public FISMClientData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A4E7 RID: 42215 RVA: 0x000EAA11 File Offset: 0x000E8C11
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FISMClientData(Pointer, false, true);
		}

		// Token: 0x0600A4E8 RID: 42216 RVA: 0x000EAA1B File Offset: 0x000E8C1B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FISMClientData(Pointer, MemoryOwner);
		}

		// Token: 0x04005ABD RID: 23229
		public const string __ObjectPath = "/Script/Engine.ISMClientData";

		// Token: 0x04005ABE RID: 23230
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005ABF RID: 23231
		internal static int __PropertyOffset_Instances;

		// Token: 0x04005AC0 RID: 23232
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FISMClientInstance> _Instances;
	}
}
