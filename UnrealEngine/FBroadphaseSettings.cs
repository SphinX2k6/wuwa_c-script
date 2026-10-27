using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008F4 RID: 2292
	[UnrealObjectPath("/Script/Engine.BroadphaseSettings")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FBroadphaseSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007DB7 RID: 32183 RVA: 0x000B4277 File Offset: 0x000B2477
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBroadphaseSettings._ScriptStructPtr != 0) ? FBroadphaseSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BroadphaseSettings", ref FBroadphaseSettings._ScriptStructPtr);
		}

		// Token: 0x17001D84 RID: 7556
		// (get) Token: 0x06007DB8 RID: 32184 RVA: 0x000B429B File Offset: 0x000B249B
		// (set) Token: 0x06007DB9 RID: 32185 RVA: 0x000B42AB File Offset: 0x000B24AB
		public unsafe bool bUseMBPOnClient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBroadphaseSettings.__PropertyOffset_bUseMBPOnClient) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBroadphaseSettings.__PropertyOffset_bUseMBPOnClient) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x06007DBA RID: 32186 RVA: 0x000B42BC File Offset: 0x000B24BC
		// (set) Token: 0x06007DBB RID: 32187 RVA: 0x000B42CC File Offset: 0x000B24CC
		public unsafe bool bUseMBPOnServer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBroadphaseSettings.__PropertyOffset_bUseMBPOnServer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBroadphaseSettings.__PropertyOffset_bUseMBPOnServer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x06007DBC RID: 32188 RVA: 0x000B42DD File Offset: 0x000B24DD
		// (set) Token: 0x06007DBD RID: 32189 RVA: 0x000B42ED File Offset: 0x000B24ED
		public unsafe bool bUseMBPOuterBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBroadphaseSettings.__PropertyOffset_bUseMBPOuterBounds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBroadphaseSettings.__PropertyOffset_bUseMBPOuterBounds) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x06007DBE RID: 32190 RVA: 0x000B42FE File Offset: 0x000B24FE
		// (set) Token: 0x06007DBF RID: 32191 RVA: 0x000B4312 File Offset: 0x000B2512
		public unsafe FBox MBPBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBroadphaseSettings.__PropertyOffset_MBPBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBroadphaseSettings.__PropertyOffset_MBPBounds) = value;
			}
		}

		// Token: 0x17001D88 RID: 7560
		// (get) Token: 0x06007DC0 RID: 32192 RVA: 0x000B4327 File Offset: 0x000B2527
		// (set) Token: 0x06007DC1 RID: 32193 RVA: 0x000B433B File Offset: 0x000B253B
		public unsafe FBox MBPOuterBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBroadphaseSettings.__PropertyOffset_MBPOuterBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBroadphaseSettings.__PropertyOffset_MBPOuterBounds) = value;
			}
		}

		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x06007DC2 RID: 32194 RVA: 0x000B4350 File Offset: 0x000B2550
		// (set) Token: 0x06007DC3 RID: 32195 RVA: 0x000B4360 File Offset: 0x000B2560
		public unsafe uint MBPNumSubdivs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBroadphaseSettings.__PropertyOffset_MBPNumSubdivs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBroadphaseSettings.__PropertyOffset_MBPNumSubdivs) = (int)value;
			}
		}

		// Token: 0x06007DC4 RID: 32196 RVA: 0x000B4371 File Offset: 0x000B2571
		public FBroadphaseSettings()
		{
		}

		// Token: 0x06007DC5 RID: 32197 RVA: 0x000B4379 File Offset: 0x000B2579
		public FBroadphaseSettings(bool bUseMBPOnClient, bool bUseMBPOnServer, bool bUseMBPOuterBounds, FBox MBPBounds, FBox MBPOuterBounds, uint MBPNumSubdivs)
		{
			this.bUseMBPOnClient = bUseMBPOnClient;
			this.bUseMBPOnServer = bUseMBPOnServer;
			this.bUseMBPOuterBounds = bUseMBPOuterBounds;
			this.MBPBounds = MBPBounds;
			this.MBPOuterBounds = MBPOuterBounds;
			this.MBPNumSubdivs = MBPNumSubdivs;
		}

		// Token: 0x06007DC6 RID: 32198 RVA: 0x000B43AE File Offset: 0x000B25AE
		protected override IntPtr GetUStructPtr()
		{
			return FBroadphaseSettings.StaticStruct();
		}

		// Token: 0x06007DC7 RID: 32199 RVA: 0x000B43BA File Offset: 0x000B25BA
		[NullableContext(2)]
		public FBroadphaseSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007DC8 RID: 32200 RVA: 0x000B43C4 File Offset: 0x000B25C4
		public FBroadphaseSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007DC9 RID: 32201 RVA: 0x000B43CF File Offset: 0x000B25CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBroadphaseSettings(Pointer, false, true);
		}

		// Token: 0x06007DCA RID: 32202 RVA: 0x000B43D9 File Offset: 0x000B25D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBroadphaseSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04003C3B RID: 15419
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BroadphaseSettings";

		// Token: 0x04003C3C RID: 15420
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003C3D RID: 15421
		internal static int __PropertyOffset_bUseMBPOnClient;

		// Token: 0x04003C3E RID: 15422
		internal static int __PropertyOffset_bUseMBPOnServer;

		// Token: 0x04003C3F RID: 15423
		internal static int __PropertyOffset_bUseMBPOuterBounds;

		// Token: 0x04003C40 RID: 15424
		internal static int __PropertyOffset_MBPBounds;

		// Token: 0x04003C41 RID: 15425
		internal static int __PropertyOffset_MBPOuterBounds;

		// Token: 0x04003C42 RID: 15426
		internal static int __PropertyOffset_MBPNumSubdivs;
	}
}
