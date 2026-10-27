using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200096C RID: 2412
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Console")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class UConsole : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600882A RID: 34858 RVA: 0x000C3170 File Offset: 0x000C1370
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UConsole._ClassPtr;
		}

		// Token: 0x0600882B RID: 34859 RVA: 0x000C317C File Offset: 0x000C137C
		public UConsole() : this(BuiltinUtils.AllocNativeUObject(UConsole.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600882C RID: 34860 RVA: 0x000C31A4 File Offset: 0x000C13A4
		[NullableContext(1)]
		public UConsole(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UConsole.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x0600882D RID: 34861 RVA: 0x000C31D7 File Offset: 0x000C13D7
		// (set) Token: 0x0600882E RID: 34862 RVA: 0x000C31EB File Offset: 0x000C13EB
		public unsafe ULocalPlayer ConsoleTargetPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULocalPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + UConsole.__PropertyOffset_ConsoleTargetPlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UConsole.__PropertyOffset_ConsoleTargetPlayer, value);
			}
		}

		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x0600882F RID: 34863 RVA: 0x000C3200 File Offset: 0x000C1400
		// (set) Token: 0x06008830 RID: 34864 RVA: 0x000C3214 File Offset: 0x000C1414
		public unsafe UTexture2D DefaultTexture_Black
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UConsole.__PropertyOffset_DefaultTexture_Black);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UConsole.__PropertyOffset_DefaultTexture_Black, value);
			}
		}

		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x06008831 RID: 34865 RVA: 0x000C3229 File Offset: 0x000C1429
		// (set) Token: 0x06008832 RID: 34866 RVA: 0x000C323D File Offset: 0x000C143D
		public unsafe UTexture2D DefaultTexture_White
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UConsole.__PropertyOffset_DefaultTexture_White);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UConsole.__PropertyOffset_DefaultTexture_White, value);
			}
		}

		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x06008833 RID: 34867 RVA: 0x000C3254 File Offset: 0x000C1454
		// (set) Token: 0x06008834 RID: 34868 RVA: 0x000C328D File Offset: 0x000C148D
		[Nullable(1)]
		public TArray<string> HistoryBuffer
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._HistoryBuffer) == null)
				{
					result = (this._HistoryBuffer = new TArray<string>(base.NativePtr + (IntPtr)UConsole.__PropertyOffset_HistoryBuffer, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.HistoryBuffer.CopyAssign(value);
			}
		}

		// Token: 0x06008835 RID: 34869 RVA: 0x000C329B File Offset: 0x000C149B
		static UConsole()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Console");
		}

		// Token: 0x06008836 RID: 34870 RVA: 0x000C32A9 File Offset: 0x000C14A9
		protected UConsole(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040040BB RID: 16571
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Console";

		// Token: 0x040040BC RID: 16572
		private static IntPtr _ClassPtr;

		// Token: 0x040040BD RID: 16573
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040040BE RID: 16574
		internal static int __PropertyOffset_ConsoleTargetPlayer;

		// Token: 0x040040BF RID: 16575
		internal static int __PropertyOffset_DefaultTexture_Black;

		// Token: 0x040040C0 RID: 16576
		internal static int __PropertyOffset_DefaultTexture_White;

		// Token: 0x040040C1 RID: 16577
		internal static int __PropertyOffset_HistoryBuffer;

		// Token: 0x040040C2 RID: 16578
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _HistoryBuffer;
	}
}
