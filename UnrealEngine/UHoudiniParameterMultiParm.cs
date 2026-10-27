using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014F3 RID: 5363
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterMultiParm")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 344)]
	public class UHoudiniParameterMultiParm : UHoudiniParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060136F6 RID: 79606 RVA: 0x001C92BE File Offset: 0x001C74BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterMultiParm._ClassPtr;
		}

		// Token: 0x060136F7 RID: 79607 RVA: 0x001C92CC File Offset: 0x001C74CC
		public UHoudiniParameterMultiParm() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterMultiParm.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060136F8 RID: 79608 RVA: 0x001C92F4 File Offset: 0x001C74F4
		public UHoudiniParameterMultiParm(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterMultiParm.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BE7 RID: 19431
		// (get) Token: 0x060136F9 RID: 79609 RVA: 0x001C9327 File Offset: 0x001C7527
		// (set) Token: 0x060136FA RID: 79610 RVA: 0x001C9337 File Offset: 0x001C7537
		public unsafe bool bIsShown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_bIsShown) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_bIsShown) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BE8 RID: 19432
		// (get) Token: 0x060136FB RID: 79611 RVA: 0x001C9348 File Offset: 0x001C7548
		// (set) Token: 0x060136FC RID: 79612 RVA: 0x001C9358 File Offset: 0x001C7558
		public unsafe int Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17004BE9 RID: 19433
		// (get) Token: 0x060136FD RID: 79613 RVA: 0x001C9369 File Offset: 0x001C7569
		// (set) Token: 0x060136FE RID: 79614 RVA: 0x001C937D File Offset: 0x001C757D
		public unsafe string TemplateName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_TemplateName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_TemplateName)), value);
			}
		}

		// Token: 0x17004BEA RID: 19434
		// (get) Token: 0x060136FF RID: 79615 RVA: 0x001C9392 File Offset: 0x001C7592
		// (set) Token: 0x06013700 RID: 79616 RVA: 0x001C93A2 File Offset: 0x001C75A2
		public unsafe int MultiparmValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_MultiparmValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_MultiparmValue) = value;
			}
		}

		// Token: 0x17004BEB RID: 19435
		// (get) Token: 0x06013701 RID: 79617 RVA: 0x001C93B3 File Offset: 0x001C75B3
		// (set) Token: 0x06013702 RID: 79618 RVA: 0x001C93C3 File Offset: 0x001C75C3
		public unsafe uint MultiParmInstanceNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_MultiParmInstanceNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_MultiParmInstanceNum) = (int)value;
			}
		}

		// Token: 0x17004BEC RID: 19436
		// (get) Token: 0x06013703 RID: 79619 RVA: 0x001C93D4 File Offset: 0x001C75D4
		// (set) Token: 0x06013704 RID: 79620 RVA: 0x001C93E4 File Offset: 0x001C75E4
		public unsafe uint MultiParmInstanceLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_MultiParmInstanceLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_MultiParmInstanceLength) = (int)value;
			}
		}

		// Token: 0x17004BED RID: 19437
		// (get) Token: 0x06013705 RID: 79621 RVA: 0x001C93F5 File Offset: 0x001C75F5
		// (set) Token: 0x06013706 RID: 79622 RVA: 0x001C9405 File Offset: 0x001C7605
		public unsafe uint MultiParmInstanceCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_MultiParmInstanceCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_MultiParmInstanceCount) = (int)value;
			}
		}

		// Token: 0x17004BEE RID: 19438
		// (get) Token: 0x06013707 RID: 79623 RVA: 0x001C9416 File Offset: 0x001C7616
		// (set) Token: 0x06013708 RID: 79624 RVA: 0x001C9426 File Offset: 0x001C7626
		public unsafe uint InstanceStartOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_InstanceStartOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_InstanceStartOffset) = (int)value;
			}
		}

		// Token: 0x17004BEF RID: 19439
		// (get) Token: 0x06013709 RID: 79625 RVA: 0x001C9438 File Offset: 0x001C7638
		// (set) Token: 0x0601370A RID: 79626 RVA: 0x001C9471 File Offset: 0x001C7671
		public TArray<EHoudiniMultiParmModificationType> MultiParmInstanceLastModifyArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EHoudiniMultiParmModificationType> result;
				if ((result = this._MultiParmInstanceLastModifyArray) == null)
				{
					result = (this._MultiParmInstanceLastModifyArray = new TArray<EHoudiniMultiParmModificationType>(base.NativePtr + (IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_MultiParmInstanceLastModifyArray, this));
				}
				return result;
			}
			set
			{
				this.MultiParmInstanceLastModifyArray.CopyAssign(value);
			}
		}

		// Token: 0x17004BF0 RID: 19440
		// (get) Token: 0x0601370B RID: 79627 RVA: 0x001C947F File Offset: 0x001C767F
		// (set) Token: 0x0601370C RID: 79628 RVA: 0x001C948F File Offset: 0x001C768F
		public unsafe int DefaultInstanceCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_DefaultInstanceCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterMultiParm.__PropertyOffset_DefaultInstanceCount) = value;
			}
		}

		// Token: 0x0601370D RID: 79629 RVA: 0x001C94A0 File Offset: 0x001C76A0
		static UHoudiniParameterMultiParm()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterMultiParm");
		}

		// Token: 0x0601370E RID: 79630 RVA: 0x001C94AE File Offset: 0x001C76AE
		protected UHoudiniParameterMultiParm(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A80C RID: 43020
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterMultiParm";

		// Token: 0x0400A80D RID: 43021
		private static IntPtr _ClassPtr;

		// Token: 0x0400A80E RID: 43022
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A80F RID: 43023
		internal static int __PropertyOffset_bIsShown;

		// Token: 0x0400A810 RID: 43024
		internal static int __PropertyOffset_Value;

		// Token: 0x0400A811 RID: 43025
		internal static int __PropertyOffset_TemplateName;

		// Token: 0x0400A812 RID: 43026
		internal static int __PropertyOffset_MultiparmValue;

		// Token: 0x0400A813 RID: 43027
		internal static int __PropertyOffset_MultiParmInstanceNum;

		// Token: 0x0400A814 RID: 43028
		internal static int __PropertyOffset_MultiParmInstanceLength;

		// Token: 0x0400A815 RID: 43029
		internal static int __PropertyOffset_MultiParmInstanceCount;

		// Token: 0x0400A816 RID: 43030
		internal static int __PropertyOffset_InstanceStartOffset;

		// Token: 0x0400A817 RID: 43031
		internal static int __PropertyOffset_MultiParmInstanceLastModifyArray;

		// Token: 0x0400A818 RID: 43032
		[Nullable(2)]
		private TArray<EHoudiniMultiParmModificationType> _MultiParmInstanceLastModifyArray;

		// Token: 0x0400A819 RID: 43033
		internal static int __PropertyOffset_DefaultInstanceCount;
	}
}
