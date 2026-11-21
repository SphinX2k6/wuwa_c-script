using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200019E RID: 414
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CameraShakeInfo")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FCameraShakeInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001BEB RID: 7147 RVA: 0x000296DF File Offset: 0x000278DF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraShakeInfo._ScriptStructPtr != 0) ? FCameraShakeInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CameraShakeInfo", ref FCameraShakeInfo._ScriptStructPtr);
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001BEC RID: 7148 RVA: 0x00029704 File Offset: 0x00027904
		// (set) Token: 0x06001BED RID: 7149 RVA: 0x00029747 File Offset: 0x00027947
		public FCameraShakeDuration Duration
		{
			get
			{
				base.FastCheckIsValid();
				FCameraShakeDuration result;
				if ((result = this._Duration) == null)
				{
					result = (this._Duration = new FCameraShakeDuration(base.NativePtr + (IntPtr)FCameraShakeInfo.__PropertyOffset_Duration, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraShakeDuration.StaticStruct(), base.NativePtr + (IntPtr)FCameraShakeInfo.__PropertyOffset_Duration, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x00029768 File Offset: 0x00027968
		// (set) Token: 0x06001BEF RID: 7151 RVA: 0x00029778 File Offset: 0x00027978
		public unsafe float BlendIn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraShakeInfo.__PropertyOffset_BlendIn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraShakeInfo.__PropertyOffset_BlendIn) = value;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x00029789 File Offset: 0x00027989
		// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x00029799 File Offset: 0x00027999
		public unsafe float BlendOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraShakeInfo.__PropertyOffset_BlendOut);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraShakeInfo.__PropertyOffset_BlendOut) = value;
			}
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x000297AA File Offset: 0x000279AA
		public FCameraShakeInfo()
		{
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x000297B2 File Offset: 0x000279B2
		protected override IntPtr GetUStructPtr()
		{
			return FCameraShakeInfo.StaticStruct();
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x000297BE File Offset: 0x000279BE
		[NullableContext(2)]
		public FCameraShakeInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x000297C8 File Offset: 0x000279C8
		public FCameraShakeInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x000297D3 File Offset: 0x000279D3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraShakeInfo(Pointer, false, true);
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x000297DD File Offset: 0x000279DD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraShakeInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04000918 RID: 2328
		public const string __ObjectPath = "/Script/Engine.CameraShakeInfo";

		// Token: 0x04000919 RID: 2329
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400091A RID: 2330
		internal static int __PropertyOffset_Duration;

		// Token: 0x0400091B RID: 2331
		[Nullable(2)]
		private FCameraShakeDuration _Duration;

		// Token: 0x0400091C RID: 2332
		internal static int __PropertyOffset_BlendIn;

		// Token: 0x0400091D RID: 2333
		internal static int __PropertyOffset_BlendOut;
	}
}
