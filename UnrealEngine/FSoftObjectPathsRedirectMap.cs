using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001120 RID: 4384
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoftObjectPathsRedirectMap")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FSoftObjectPathsRedirectMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601001C RID: 65564 RVA: 0x001791CA File Offset: 0x001773CA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoftObjectPathsRedirectMap._ScriptStructPtr != 0) ? FSoftObjectPathsRedirectMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoftObjectPathsRedirectMap", ref FSoftObjectPathsRedirectMap._ScriptStructPtr);
		}

		// Token: 0x17003E79 RID: 15993
		// (get) Token: 0x0601001D RID: 65565 RVA: 0x001791F0 File Offset: 0x001773F0
		// (set) Token: 0x0601001E RID: 65566 RVA: 0x00179233 File Offset: 0x00177433
		public TMap<string, string> RedirectMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._RedirectMap) == null)
				{
					result = (this._RedirectMap = new TMap<string, string>(base.NativePtr + (IntPtr)FSoftObjectPathsRedirectMap.__PropertyOffset_RedirectMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RedirectMap.CopyAssign(value);
			}
		}

		// Token: 0x0601001F RID: 65567 RVA: 0x00179241 File Offset: 0x00177441
		public FSoftObjectPathsRedirectMap()
		{
		}

		// Token: 0x06010020 RID: 65568 RVA: 0x00179249 File Offset: 0x00177449
		public FSoftObjectPathsRedirectMap(TMap<string, string> RedirectMap)
		{
			this.RedirectMap = RedirectMap;
		}

		// Token: 0x06010021 RID: 65569 RVA: 0x00179258 File Offset: 0x00177458
		protected override IntPtr GetUStructPtr()
		{
			return FSoftObjectPathsRedirectMap.StaticStruct();
		}

		// Token: 0x06010022 RID: 65570 RVA: 0x00179264 File Offset: 0x00177464
		[NullableContext(2)]
		public FSoftObjectPathsRedirectMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010023 RID: 65571 RVA: 0x0017926E File Offset: 0x0017746E
		public FSoftObjectPathsRedirectMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010024 RID: 65572 RVA: 0x00179279 File Offset: 0x00177479
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoftObjectPathsRedirectMap(Pointer, false, true);
		}

		// Token: 0x06010025 RID: 65573 RVA: 0x00179283 File Offset: 0x00177483
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoftObjectPathsRedirectMap(Pointer, MemoryOwner);
		}

		// Token: 0x04008997 RID: 35223
		public const string __ObjectPath = "/Script/Engine.SoftObjectPathsRedirectMap";

		// Token: 0x04008998 RID: 35224
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008999 RID: 35225
		internal static int __PropertyOffset_RedirectMap;

		// Token: 0x0400899A RID: 35226
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _RedirectMap;
	}
}
