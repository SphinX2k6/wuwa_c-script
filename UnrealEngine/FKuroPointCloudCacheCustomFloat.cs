using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A28 RID: 6696
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointCloudCacheCustomFloat")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroPointCloudCacheCustomFloat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018C82 RID: 101506 RVA: 0x00249F7D File Offset: 0x0024817D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroPointCloudCacheCustomFloat._ScriptStructPtr != 0) ? FKuroPointCloudCacheCustomFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroPointCloud.KuroPointCloudCacheCustomFloat", ref FKuroPointCloudCacheCustomFloat._ScriptStructPtr);
		}

		// Token: 0x17006241 RID: 25153
		// (get) Token: 0x06018C83 RID: 101507 RVA: 0x00249FA1 File Offset: 0x002481A1
		// (set) Token: 0x06018C84 RID: 101508 RVA: 0x00249FB5 File Offset: 0x002481B5
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPointCloudCacheCustomFloat.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPointCloudCacheCustomFloat.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17006242 RID: 25154
		// (get) Token: 0x06018C85 RID: 101509 RVA: 0x00249FCA File Offset: 0x002481CA
		// (set) Token: 0x06018C86 RID: 101510 RVA: 0x00249FDA File Offset: 0x002481DA
		public unsafe int Channel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPointCloudCacheCustomFloat.__PropertyOffset_Channel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPointCloudCacheCustomFloat.__PropertyOffset_Channel) = value;
			}
		}

		// Token: 0x17006243 RID: 25155
		// (get) Token: 0x06018C87 RID: 101511 RVA: 0x00249FEC File Offset: 0x002481EC
		// (set) Token: 0x06018C88 RID: 101512 RVA: 0x0024A02F File Offset: 0x0024822F
		public TArray<float> Data
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new TArray<float>(base.NativePtr + (IntPtr)FKuroPointCloudCacheCustomFloat.__PropertyOffset_Data, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Data.CopyAssign(value);
			}
		}

		// Token: 0x06018C89 RID: 101513 RVA: 0x0024A03D File Offset: 0x0024823D
		public FKuroPointCloudCacheCustomFloat()
		{
		}

		// Token: 0x06018C8A RID: 101514 RVA: 0x0024A045 File Offset: 0x00248245
		public FKuroPointCloudCacheCustomFloat(FName Name, int Channel, TArray<float> Data)
		{
			this.Name = Name;
			this.Channel = Channel;
			this.Data = Data;
		}

		// Token: 0x06018C8B RID: 101515 RVA: 0x0024A062 File Offset: 0x00248262
		protected override IntPtr GetUStructPtr()
		{
			return FKuroPointCloudCacheCustomFloat.StaticStruct();
		}

		// Token: 0x06018C8C RID: 101516 RVA: 0x0024A06E File Offset: 0x0024826E
		[NullableContext(2)]
		public FKuroPointCloudCacheCustomFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018C8D RID: 101517 RVA: 0x0024A078 File Offset: 0x00248278
		public FKuroPointCloudCacheCustomFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018C8E RID: 101518 RVA: 0x0024A083 File Offset: 0x00248283
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroPointCloudCacheCustomFloat(Pointer, false, true);
		}

		// Token: 0x06018C8F RID: 101519 RVA: 0x0024A08D File Offset: 0x0024828D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroPointCloudCacheCustomFloat(Pointer, MemoryOwner);
		}

		// Token: 0x0400D66A RID: 54890
		public const string __ObjectPath = "/Script/KuroPointCloud.KuroPointCloudCacheCustomFloat";

		// Token: 0x0400D66B RID: 54891
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D66C RID: 54892
		internal static int __PropertyOffset_Name;

		// Token: 0x0400D66D RID: 54893
		internal static int __PropertyOffset_Channel;

		// Token: 0x0400D66E RID: 54894
		internal static int __PropertyOffset_Data;

		// Token: 0x0400D66F RID: 54895
		[Nullable(2)]
		private TArray<float> _Data;
	}
}
