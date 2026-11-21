using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000B6 RID: 182
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTTaskNode")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public abstract class UBTTaskNode : UBTNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000DB7 RID: 3511 RVA: 0x000159CD File Offset: 0x00013BCD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTaskNode._ClassPtr;
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x000159DC File Offset: 0x00013BDC
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x00015A15 File Offset: 0x00013C15
		public TArray<UBTService> Services
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBTService> result;
				if ((result = this._Services) == null)
				{
					result = (this._Services = new TArray<UBTService>(base.NativePtr + (IntPtr)UBTTaskNode.__PropertyOffset_Services, this));
				}
				return result;
			}
			set
			{
				this.Services.CopyAssign(value);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x00015A23 File Offset: 0x00013C23
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x00015A3C File Offset: 0x00013C3C
		public unsafe bool bIgnoreRestartSelf
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTaskNode.__PropertyOffset_bIgnoreRestartSelf) & UBTTaskNode.__PropertyMask_bIgnoreRestartSelf) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTaskNode.__PropertyOffset_bIgnoreRestartSelf) = ((*(base.NativePtr + (IntPtr)UBTTaskNode.__PropertyOffset_bIgnoreRestartSelf) & ~UBTTaskNode.__PropertyMask_bIgnoreRestartSelf) | (value ? UBTTaskNode.__PropertyMask_bIgnoreRestartSelf : 0));
			}
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00015A6C File Offset: 0x00013C6C
		static UBTTaskNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTaskNode");
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00015A7C File Offset: 0x00013C7C
		protected UBTTaskNode() : this(BuiltinUtils.AllocNativeUObject(UBTTaskNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00015AA4 File Offset: 0x00013CA4
		protected UBTTaskNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000286 RID: 646
		public new const string __ObjectPath = "/Script/AIModule.BTTaskNode";

		// Token: 0x04000287 RID: 647
		private static IntPtr _ClassPtr;

		// Token: 0x04000288 RID: 648
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000289 RID: 649
		internal static int __PropertyOffset_Services;

		// Token: 0x0400028A RID: 650
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBTService> _Services;

		// Token: 0x0400028B RID: 651
		internal static int __PropertyOffset_bIgnoreRestartSelf;

		// Token: 0x0400028C RID: 652
		internal static byte __PropertyMask_bIgnoreRestartSelf;
	}
}
